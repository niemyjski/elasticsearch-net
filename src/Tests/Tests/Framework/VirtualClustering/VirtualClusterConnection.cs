using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Elasticsearch.Net;
using FluentAssertions;
using Nest;
using Tests.Framework.VirtualClustering.MockResponses;
using Tests.Framework.VirtualClustering.Providers;
using Tests.Framework.VirtualClustering.Rules;
using HttpMethod = Elasticsearch.Net.HttpMethod;

namespace Tests.Framework.VirtualClustering
{
	public class VirtualClusterConnection : InMemoryConnection
	{
		private static readonly object Lock = new object();

		private static byte[] _defaultResponseBytes;

		private VirtualCluster _cluster;
		private readonly TestableDateTimeProvider _dateTimeProvider;
		private IDictionary<int, State> _calls = new Dictionary<int, State>();

		public VirtualClusterConnection(VirtualCluster cluster, TestableDateTimeProvider dateTimeProvider)
		{
			UpdateCluster(cluster);
			_dateTimeProvider = dateTimeProvider;
		}

		private static object DefaultResponse
		{
			get
			{
				var response = new
				{
					name = "Razor Fist",
					cluster_name = "elasticsearch-test-cluster",
					version = new
					{
						number = "2.0.0",
						build_hash = "af1dc6d8099487755c3143c931665b709de3c764",
						build_timestamp = "2015-07-07T11:28:47Z",
						build_snapshot = true,
						lucene_version = "5.2.1"
					},
					tagline = "You Know, for Search"
				};
				return response;
			}
		}

		public void UpdateCluster(VirtualCluster cluster)
		{
			if (cluster == null) return;

			lock (Lock)
			{
				_cluster = cluster;
				_calls = cluster.Nodes.ToDictionary(n => n.Uri.Port, v => new State());
			}
		}

		public bool IsSniffRequest(RequestData requestData) =>
			requestData.PathAndQuery.StartsWith(RequestPipeline.SniffPath, StringComparison.Ordinal);

		public bool IsPingRequest(RequestData requestData) => requestData.PathAndQuery == "/" && requestData.Method == HttpMethod.HEAD;

		public override TResponse Request<TResponse>(RequestData requestData)
		{
			_calls.Should().ContainKey(requestData.Uri.Port);
			try
			{
				var state = _calls[requestData.Uri.Port];
				if (IsSniffRequest(requestData))
				{
					var sniffed = Interlocked.Increment(ref state.Sniffed);
					return HandleRules<TResponse, ISniffRule>(
						requestData,
						_cluster.SniffingRules,
						requestData.RequestTimeout,
						(r) => UpdateCluster(r.NewClusterState),
						(r) => SniffResponseBytes.Create(_cluster.Nodes, _cluster.PublishAddressOverride, _cluster.SniffShouldReturnFqnd)
					);
				}
				if (IsPingRequest(requestData))
				{
					var pinged = Interlocked.Increment(ref state.Pinged);
					return HandleRules<TResponse, IRule>(
						requestData,
						_cluster.PingingRules,
						requestData.PingTimeout,
						(r) => { },
						(r) => null //HEAD request
					);
				}
				var called = Interlocked.Increment(ref state.Called);
				return HandleRules<TResponse, IClientCallRule>(
					requestData,
					_cluster.ClientCallRules,
					requestData.RequestTimeout,
					(r) => { },
					CallResponse
				);
			}
			catch (HttpRequestException e)
			{
				return ResponseBuilder.ToResponse<TResponse>(requestData, e, null, null, Stream.Null);
			}
		}

		private TResponse HandleRules<TResponse, TRule>(
			RequestData requestData,
			IEnumerable<TRule> rules,
			TimeSpan timeout,
			Action<TRule> beforeReturn,
			Func<TRule, byte[]> successResponse
		)
			where TResponse : class, IElasticsearchResponse, new()
			where TRule : IRule
		{
			requestData.MadeItToResponse = true;

			var state = _calls[requestData.Uri.Port];
			foreach (var rule in rules.Where(s => s.OnPort.HasValue))
			{
				var always = rule.Times.Match(t => true, t => false);
				var times = rule.Times.Match(t => -1, t => t);
				if (rule.OnPort.Value == requestData.Uri.Port)
				{
					if (always)
						return Always<TResponse, TRule>(requestData, timeout, beforeReturn, successResponse, rule);

					return Sometimes<TResponse, TRule>(requestData, timeout, beforeReturn, successResponse, state, rule, times);
				}
			}
			foreach (var rule in rules.Where(s => !s.OnPort.HasValue))
			{
				var always = rule.Times.Match(t => true, t => false);
				var times = rule.Times.Match(t => -1, t => t);
				if (always)
					return Always<TResponse, TRule>(requestData, timeout, beforeReturn, successResponse, rule);

				return Sometimes<TResponse, TRule>(requestData, timeout, beforeReturn, successResponse, state, rule, times);
			}
			return ReturnConnectionStatus<TResponse>(requestData, successResponse(default(TRule)));
		}

		private TResponse Always<TResponse, TRule>(RequestData requestData, TimeSpan timeout, Action<TRule> beforeReturn,
			Func<TRule, byte[]> successResponse, TRule rule
		)
			where TResponse : class, IElasticsearchResponse, new()
			where TRule : IRule
		{
			if (rule.Takes.HasValue)
			{
				var time = timeout < rule.Takes.Value ? timeout : rule.Takes.Value;
				_dateTimeProvider.ChangeTime(d => d.Add(time));
				if (rule.Takes.Value > requestData.RequestTimeout)
					throw new HttpRequestException(
						$"Request timed out after {time} : call configured to take {rule.Takes.Value} while requestTimeout was: {timeout}");
			}

			return rule.Succeeds
				? Success<TResponse, TRule>(requestData, beforeReturn, successResponse, rule)
				: Fail<TResponse, TRule>(requestData, rule);
		}

		private TResponse Sometimes<TResponse, TRule>(
			RequestData requestData, TimeSpan timeout, Action<TRule> beforeReturn, Func<TRule, byte[]> successResponse, State state, TRule rule,
			int times
		)
			where TResponse : class, IElasticsearchResponse, new()
			where TRule : IRule
		{
			if (rule.Takes.HasValue)
			{
				var time = timeout < rule.Takes.Value ? timeout : rule.Takes.Value;
				_dateTimeProvider.ChangeTime(d => d.Add(time));
				if (rule.Takes.Value > requestData.RequestTimeout)
					throw new HttpRequestException(
						$"Request timed out after {time} : call configured to take {rule.Takes.Value} while requestTimeout was: {timeout}");
			}

			if (rule.Succeeds && times >= state.Successes)
				return Success<TResponse, TRule>(requestData, beforeReturn, successResponse, rule);
			else if (rule.Succeeds) return Fail<TResponse, TRule>(requestData, rule);

			if (!rule.Succeeds && times >= state.Failures)
				return Fail<TResponse, TRule>(requestData, rule);

			return Success<TResponse, TRule>(requestData, beforeReturn, successResponse, rule);
		}

		private TResponse Fail<TResponse, TRule>(RequestData requestData, TRule rule, Union<Exception, int> returnOverride = null)
			where TResponse : class, IElasticsearchResponse, new()
			where TRule : IRule
		{
			var state = _calls[requestData.Uri.Port];
			var failed = Interlocked.Increment(ref state.Failures);
			var ret = returnOverride ?? rule.Return;

			if (ret == null)
				throw new HttpRequestException();

			return ret.Match(
				(e) => throw e,
				(statusCode) => ReturnConnectionStatus<TResponse>(requestData, CallResponse(rule),
					//make sure we never return a valid status code in Fail responses because of a bad rule.
					statusCode >= 200 && statusCode < 300 ? 502 : statusCode, rule.ReturnContentType)
			);
		}

		private TResponse Success<TResponse, TRule>(RequestData requestData, Action<TRule> beforeReturn, Func<TRule, byte[]> successResponse,
			TRule rule
		)
			where TResponse : class, IElasticsearchResponse, new()
			where TRule : IRule
		{
			var state = _calls[requestData.Uri.Port];
			var succeeded = Interlocked.Increment(ref state.Successes);
			beforeReturn?.Invoke(rule);
			return ReturnConnectionStatus<TResponse>(requestData, successResponse(rule), contentType: rule.ReturnContentType);
		}

		private static byte[] CallResponse<TRule>(TRule rule)
			where TRule : IRule
		{
			if (rule?.ReturnResponse != null)
				return rule.ReturnResponse;

			if (_defaultResponseBytes != null) return _defaultResponseBytes;

			var response = DefaultResponse;
			using (var ms = new MemoryStream())
			{
				new LowLevelRequestResponseSerializer().Serialize(response, ms);
				_defaultResponseBytes = ms.ToArray();
			}
			return _defaultResponseBytes;
		}

		public override Task<TResponse> RequestAsync<TResponse>(RequestData requestData, CancellationToken cancellationToken) =>
			Task.FromResult(Request<TResponse>(requestData));

		private class State
		{
			public int Called;
			public int Failures;
			public int Pinged;
			public int Sniffed;
			public int Successes;
		}
	}
}
