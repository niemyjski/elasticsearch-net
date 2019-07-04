// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗  
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝  
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//  
// This file is automatically generated 
// Please do not edit these files manually
// Run the following in the root of the repos:
//
// 		*NIX 		:	./build.sh codegen
// 		Windows 	:	build.bat codegen
//
// -----------------------------------------------
// ReSharper disable RedundantUsingDirective
using System;
using System.Threading;
using System.Threading.Tasks;
using Elasticsearch.Net.Specification.CrossClusterReplicationApi;

// ReSharper disable once CheckNamespace
// ReSharper disable RedundantTypeArgumentsOfMethod
namespace Nest.Specification.CrossClusterReplicationApi
{
	///<summary>
	/// Cross Cluster Replication APIs.
	/// <para>Not intended to be instantiated directly. Use the <see cref = "IElasticClient.CrossClusterReplication"/> property
	/// on <see cref = "IElasticClient"/>.
	///</para>
	///</summary>
	public class CrossClusterReplicationNamespace : NamespacedClientProxy
	{
		internal CrossClusterReplicationNamespace(ElasticClient client): base(client)
		{
		}

		/// <summary>
		/// <c>DELETE</c> request to the <c>ccr.delete_auto_follow_pattern</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-delete-auto-follow-pattern.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-delete-auto-follow-pattern.html</a>
		/// </summary>
		public DeleteAutoFollowPatternResponse DeleteAutoFollowPattern(Name name, Func<DeleteAutoFollowPatternDescriptor, IDeleteAutoFollowPatternRequest> selector = null) => DeleteAutoFollowPattern(selector.InvokeOrDefault(new DeleteAutoFollowPatternDescriptor(name: name)));
		/// <summary>
		/// <c>DELETE</c> request to the <c>ccr.delete_auto_follow_pattern</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-delete-auto-follow-pattern.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-delete-auto-follow-pattern.html</a>
		/// </summary>
		public Task<DeleteAutoFollowPatternResponse> DeleteAutoFollowPatternAsync(Name name, Func<DeleteAutoFollowPatternDescriptor, IDeleteAutoFollowPatternRequest> selector = null, CancellationToken ct = default) => DeleteAutoFollowPatternAsync(selector.InvokeOrDefault(new DeleteAutoFollowPatternDescriptor(name: name)), ct);
		/// <summary>
		/// <c>DELETE</c> request to the <c>ccr.delete_auto_follow_pattern</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-delete-auto-follow-pattern.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-delete-auto-follow-pattern.html</a>
		/// </summary>
		public DeleteAutoFollowPatternResponse DeleteAutoFollowPattern(IDeleteAutoFollowPatternRequest request) => DoRequest<IDeleteAutoFollowPatternRequest, DeleteAutoFollowPatternResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>DELETE</c> request to the <c>ccr.delete_auto_follow_pattern</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-delete-auto-follow-pattern.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-delete-auto-follow-pattern.html</a>
		/// </summary>
		public Task<DeleteAutoFollowPatternResponse> DeleteAutoFollowPatternAsync(IDeleteAutoFollowPatternRequest request, CancellationToken ct = default) => DoRequestAsync<IDeleteAutoFollowPatternRequest, DeleteAutoFollowPatternResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>PUT</c> request to the <c>ccr.follow</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-put-follow.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-put-follow.html</a>
		/// </summary>
		public CreateFollowIndexResponse CreateFollowIndex(IndexName index, Func<CreateFollowIndexDescriptor, ICreateFollowIndexRequest> selector) => CreateFollowIndex(selector.InvokeOrDefault(new CreateFollowIndexDescriptor(index: index)));
		/// <summary>
		/// <c>PUT</c> request to the <c>ccr.follow</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-put-follow.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-put-follow.html</a>
		/// </summary>
		public Task<CreateFollowIndexResponse> CreateFollowIndexAsync(IndexName index, Func<CreateFollowIndexDescriptor, ICreateFollowIndexRequest> selector, CancellationToken ct = default) => CreateFollowIndexAsync(selector.InvokeOrDefault(new CreateFollowIndexDescriptor(index: index)), ct);
		/// <summary>
		/// <c>PUT</c> request to the <c>ccr.follow</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-put-follow.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-put-follow.html</a>
		/// </summary>
		public CreateFollowIndexResponse CreateFollowIndex(ICreateFollowIndexRequest request) => DoRequest<ICreateFollowIndexRequest, CreateFollowIndexResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>PUT</c> request to the <c>ccr.follow</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-put-follow.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-put-follow.html</a>
		/// </summary>
		public Task<CreateFollowIndexResponse> CreateFollowIndexAsync(ICreateFollowIndexRequest request, CancellationToken ct = default) => DoRequestAsync<ICreateFollowIndexRequest, CreateFollowIndexResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>ccr.follow_info</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-follow-info.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-follow-info.html</a>
		/// </summary>
		public FollowInfoResponse FollowInfo(Indices index, Func<FollowInfoDescriptor, IFollowInfoRequest> selector = null) => FollowInfo(selector.InvokeOrDefault(new FollowInfoDescriptor(index: index)));
		/// <summary>
		/// <c>GET</c> request to the <c>ccr.follow_info</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-follow-info.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-follow-info.html</a>
		/// </summary>
		public Task<FollowInfoResponse> FollowInfoAsync(Indices index, Func<FollowInfoDescriptor, IFollowInfoRequest> selector = null, CancellationToken ct = default) => FollowInfoAsync(selector.InvokeOrDefault(new FollowInfoDescriptor(index: index)), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>ccr.follow_info</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-follow-info.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-follow-info.html</a>
		/// </summary>
		public FollowInfoResponse FollowInfo(IFollowInfoRequest request) => DoRequest<IFollowInfoRequest, FollowInfoResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>GET</c> request to the <c>ccr.follow_info</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-follow-info.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-follow-info.html</a>
		/// </summary>
		public Task<FollowInfoResponse> FollowInfoAsync(IFollowInfoRequest request, CancellationToken ct = default) => DoRequestAsync<IFollowInfoRequest, FollowInfoResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>ccr.follow_stats</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-follow-stats.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-follow-stats.html</a>
		/// </summary>
		public FollowIndexStatsResponse FollowIndexStats(Indices index, Func<FollowIndexStatsDescriptor, IFollowIndexStatsRequest> selector = null) => FollowIndexStats(selector.InvokeOrDefault(new FollowIndexStatsDescriptor(index: index)));
		/// <summary>
		/// <c>GET</c> request to the <c>ccr.follow_stats</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-follow-stats.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-follow-stats.html</a>
		/// </summary>
		public Task<FollowIndexStatsResponse> FollowIndexStatsAsync(Indices index, Func<FollowIndexStatsDescriptor, IFollowIndexStatsRequest> selector = null, CancellationToken ct = default) => FollowIndexStatsAsync(selector.InvokeOrDefault(new FollowIndexStatsDescriptor(index: index)), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>ccr.follow_stats</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-follow-stats.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-follow-stats.html</a>
		/// </summary>
		public FollowIndexStatsResponse FollowIndexStats(IFollowIndexStatsRequest request) => DoRequest<IFollowIndexStatsRequest, FollowIndexStatsResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>GET</c> request to the <c>ccr.follow_stats</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-follow-stats.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-follow-stats.html</a>
		/// </summary>
		public Task<FollowIndexStatsResponse> FollowIndexStatsAsync(IFollowIndexStatsRequest request, CancellationToken ct = default) => DoRequestAsync<IFollowIndexStatsRequest, FollowIndexStatsResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>ccr.get_auto_follow_pattern</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-auto-follow-pattern.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-auto-follow-pattern.html</a>
		/// </summary>
		public GetAutoFollowPatternResponse GetAutoFollowPattern(Name name = null, Func<GetAutoFollowPatternDescriptor, IGetAutoFollowPatternRequest> selector = null) => GetAutoFollowPattern(selector.InvokeOrDefault(new GetAutoFollowPatternDescriptor().Name(name: name)));
		/// <summary>
		/// <c>GET</c> request to the <c>ccr.get_auto_follow_pattern</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-auto-follow-pattern.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-auto-follow-pattern.html</a>
		/// </summary>
		public Task<GetAutoFollowPatternResponse> GetAutoFollowPatternAsync(Name name = null, Func<GetAutoFollowPatternDescriptor, IGetAutoFollowPatternRequest> selector = null, CancellationToken ct = default) => GetAutoFollowPatternAsync(selector.InvokeOrDefault(new GetAutoFollowPatternDescriptor().Name(name: name)), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>ccr.get_auto_follow_pattern</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-auto-follow-pattern.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-auto-follow-pattern.html</a>
		/// </summary>
		public GetAutoFollowPatternResponse GetAutoFollowPattern(IGetAutoFollowPatternRequest request) => DoRequest<IGetAutoFollowPatternRequest, GetAutoFollowPatternResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>GET</c> request to the <c>ccr.get_auto_follow_pattern</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-auto-follow-pattern.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-auto-follow-pattern.html</a>
		/// </summary>
		public Task<GetAutoFollowPatternResponse> GetAutoFollowPatternAsync(IGetAutoFollowPatternRequest request, CancellationToken ct = default) => DoRequestAsync<IGetAutoFollowPatternRequest, GetAutoFollowPatternResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>POST</c> request to the <c>ccr.pause_follow</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-post-pause-follow.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-post-pause-follow.html</a>
		/// </summary>
		public PauseFollowIndexResponse PauseFollowIndex(IndexName index, Func<PauseFollowIndexDescriptor, IPauseFollowIndexRequest> selector = null) => PauseFollowIndex(selector.InvokeOrDefault(new PauseFollowIndexDescriptor(index: index)));
		/// <summary>
		/// <c>POST</c> request to the <c>ccr.pause_follow</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-post-pause-follow.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-post-pause-follow.html</a>
		/// </summary>
		public Task<PauseFollowIndexResponse> PauseFollowIndexAsync(IndexName index, Func<PauseFollowIndexDescriptor, IPauseFollowIndexRequest> selector = null, CancellationToken ct = default) => PauseFollowIndexAsync(selector.InvokeOrDefault(new PauseFollowIndexDescriptor(index: index)), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>ccr.pause_follow</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-post-pause-follow.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-post-pause-follow.html</a>
		/// </summary>
		public PauseFollowIndexResponse PauseFollowIndex(IPauseFollowIndexRequest request) => DoRequest<IPauseFollowIndexRequest, PauseFollowIndexResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>ccr.pause_follow</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-post-pause-follow.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-post-pause-follow.html</a>
		/// </summary>
		public Task<PauseFollowIndexResponse> PauseFollowIndexAsync(IPauseFollowIndexRequest request, CancellationToken ct = default) => DoRequestAsync<IPauseFollowIndexRequest, PauseFollowIndexResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>PUT</c> request to the <c>ccr.put_auto_follow_pattern</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-put-auto-follow-pattern.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-put-auto-follow-pattern.html</a>
		/// </summary>
		public CreateAutoFollowPatternResponse CreateAutoFollowPattern(Name name, Func<CreateAutoFollowPatternDescriptor, ICreateAutoFollowPatternRequest> selector) => CreateAutoFollowPattern(selector.InvokeOrDefault(new CreateAutoFollowPatternDescriptor(name: name)));
		/// <summary>
		/// <c>PUT</c> request to the <c>ccr.put_auto_follow_pattern</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-put-auto-follow-pattern.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-put-auto-follow-pattern.html</a>
		/// </summary>
		public Task<CreateAutoFollowPatternResponse> CreateAutoFollowPatternAsync(Name name, Func<CreateAutoFollowPatternDescriptor, ICreateAutoFollowPatternRequest> selector, CancellationToken ct = default) => CreateAutoFollowPatternAsync(selector.InvokeOrDefault(new CreateAutoFollowPatternDescriptor(name: name)), ct);
		/// <summary>
		/// <c>PUT</c> request to the <c>ccr.put_auto_follow_pattern</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-put-auto-follow-pattern.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-put-auto-follow-pattern.html</a>
		/// </summary>
		public CreateAutoFollowPatternResponse CreateAutoFollowPattern(ICreateAutoFollowPatternRequest request) => DoRequest<ICreateAutoFollowPatternRequest, CreateAutoFollowPatternResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>PUT</c> request to the <c>ccr.put_auto_follow_pattern</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-put-auto-follow-pattern.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-put-auto-follow-pattern.html</a>
		/// </summary>
		public Task<CreateAutoFollowPatternResponse> CreateAutoFollowPatternAsync(ICreateAutoFollowPatternRequest request, CancellationToken ct = default) => DoRequestAsync<ICreateAutoFollowPatternRequest, CreateAutoFollowPatternResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>POST</c> request to the <c>ccr.resume_follow</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-post-resume-follow.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-post-resume-follow.html</a>
		/// </summary>
		public ResumeFollowIndexResponse ResumeFollowIndex(IndexName index, Func<ResumeFollowIndexDescriptor, IResumeFollowIndexRequest> selector = null) => ResumeFollowIndex(selector.InvokeOrDefault(new ResumeFollowIndexDescriptor(index: index)));
		/// <summary>
		/// <c>POST</c> request to the <c>ccr.resume_follow</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-post-resume-follow.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-post-resume-follow.html</a>
		/// </summary>
		public Task<ResumeFollowIndexResponse> ResumeFollowIndexAsync(IndexName index, Func<ResumeFollowIndexDescriptor, IResumeFollowIndexRequest> selector = null, CancellationToken ct = default) => ResumeFollowIndexAsync(selector.InvokeOrDefault(new ResumeFollowIndexDescriptor(index: index)), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>ccr.resume_follow</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-post-resume-follow.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-post-resume-follow.html</a>
		/// </summary>
		public ResumeFollowIndexResponse ResumeFollowIndex(IResumeFollowIndexRequest request) => DoRequest<IResumeFollowIndexRequest, ResumeFollowIndexResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>ccr.resume_follow</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-post-resume-follow.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-post-resume-follow.html</a>
		/// </summary>
		public Task<ResumeFollowIndexResponse> ResumeFollowIndexAsync(IResumeFollowIndexRequest request, CancellationToken ct = default) => DoRequestAsync<IResumeFollowIndexRequest, ResumeFollowIndexResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>ccr.stats</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-stats.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-stats.html</a>
		/// </summary>
		public CcrStatsResponse Stats(Func<CcrStatsDescriptor, ICcrStatsRequest> selector = null) => Stats(selector.InvokeOrDefault(new CcrStatsDescriptor()));
		/// <summary>
		/// <c>GET</c> request to the <c>ccr.stats</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-stats.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-stats.html</a>
		/// </summary>
		public Task<CcrStatsResponse> StatsAsync(Func<CcrStatsDescriptor, ICcrStatsRequest> selector = null, CancellationToken ct = default) => StatsAsync(selector.InvokeOrDefault(new CcrStatsDescriptor()), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>ccr.stats</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-stats.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-stats.html</a>
		/// </summary>
		public CcrStatsResponse Stats(ICcrStatsRequest request) => DoRequest<ICcrStatsRequest, CcrStatsResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>GET</c> request to the <c>ccr.stats</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-stats.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-stats.html</a>
		/// </summary>
		public Task<CcrStatsResponse> StatsAsync(ICcrStatsRequest request, CancellationToken ct = default) => DoRequestAsync<ICcrStatsRequest, CcrStatsResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>POST</c> request to the <c>ccr.unfollow</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "http://www.elastic.co/guide/en/elasticsearch/reference/current">http://www.elastic.co/guide/en/elasticsearch/reference/current</a>
		/// </summary>
		public UnfollowIndexResponse UnfollowIndex(IndexName index, Func<UnfollowIndexDescriptor, IUnfollowIndexRequest> selector = null) => UnfollowIndex(selector.InvokeOrDefault(new UnfollowIndexDescriptor(index: index)));
		/// <summary>
		/// <c>POST</c> request to the <c>ccr.unfollow</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "http://www.elastic.co/guide/en/elasticsearch/reference/current">http://www.elastic.co/guide/en/elasticsearch/reference/current</a>
		/// </summary>
		public Task<UnfollowIndexResponse> UnfollowIndexAsync(IndexName index, Func<UnfollowIndexDescriptor, IUnfollowIndexRequest> selector = null, CancellationToken ct = default) => UnfollowIndexAsync(selector.InvokeOrDefault(new UnfollowIndexDescriptor(index: index)), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>ccr.unfollow</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "http://www.elastic.co/guide/en/elasticsearch/reference/current">http://www.elastic.co/guide/en/elasticsearch/reference/current</a>
		/// </summary>
		public UnfollowIndexResponse UnfollowIndex(IUnfollowIndexRequest request) => DoRequest<IUnfollowIndexRequest, UnfollowIndexResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>ccr.unfollow</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "http://www.elastic.co/guide/en/elasticsearch/reference/current">http://www.elastic.co/guide/en/elasticsearch/reference/current</a>
		/// </summary>
		public Task<UnfollowIndexResponse> UnfollowIndexAsync(IUnfollowIndexRequest request, CancellationToken ct = default) => DoRequestAsync<IUnfollowIndexRequest, UnfollowIndexResponse>(request, request.RequestParameters, ct);
	}
}