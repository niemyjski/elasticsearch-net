﻿using System;
using System.Threading;
using System.Threading.Tasks;
using Elasticsearch.Net;

namespace Nest
{
	public partial interface IElasticClient
	{
		/// <summary>
		/// The cluster state API allows to get a comprehensive state information of the whole cluster.
		/// <para> </para>
		/// <a href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/current/cluster-state.html">http://www.elasticsearch.org/guide/en/elasticsearch/reference/current/cluster-state.html</a>
		/// </summary>
		/// <param name="selector">A descriptor that describes the parameters for the cluster state operation</param>
		IClusterStateResponse ClusterState(Func<ClusterStateDescriptor, IClusterStateRequest> selector = null);

		/// <inheritdoc />
		IClusterStateResponse ClusterState(IClusterStateRequest request);

		/// <inheritdoc />
		Task<IClusterStateResponse> ClusterStateAsync(Func<ClusterStateDescriptor, IClusterStateRequest> selector = null,
			CancellationToken ct = default
		);

		/// <inheritdoc />
		Task<IClusterStateResponse> ClusterStateAsync(IClusterStateRequest request, CancellationToken ct = default);
	}

	public partial class ElasticClient
	{
		/// <inheritdoc />
		public IClusterStateResponse ClusterState(Func<ClusterStateDescriptor, IClusterStateRequest> selector = null) =>
			ClusterState(selector.InvokeOrDefault(new ClusterStateDescriptor()));

		/// <inheritdoc />
		public IClusterStateResponse ClusterState(IClusterStateRequest request) =>
			Dispatch2<IClusterStateRequest, ClusterStateResponse>(request, request.RequestParameters);

		/// <inheritdoc />
		public Task<IClusterStateResponse> ClusterStateAsync(Func<ClusterStateDescriptor, IClusterStateRequest> selector = null,
			CancellationToken ct = default
		) =>
			ClusterStateAsync(selector.InvokeOrDefault(new ClusterStateDescriptor()), ct);

		/// <inheritdoc />
		public Task<IClusterStateResponse> ClusterStateAsync(IClusterStateRequest request,
			CancellationToken ct = default
		) =>
			Dispatch2Async<IClusterStateRequest, IClusterStateResponse, ClusterStateResponse>(request, request.RequestParameters, ct);
	}
}
