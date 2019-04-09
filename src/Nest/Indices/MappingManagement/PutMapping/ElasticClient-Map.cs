﻿using System;
using System.Threading;
using System.Threading.Tasks;
using Elasticsearch.Net;

namespace Nest
{
	public partial interface IElasticClient
	{
		/// <summary>
		/// The put mapping API allows to register specific mapping definition for a specific type.
		/// <para> </para>
		/// http://www.elasticsearch.org/guide/en/elasticsearch/reference/current/indices-put-mapping.html
		/// </summary>
		/// <typeparam name="T">The type we want to map in elasticsearch</typeparam>
		/// <param name="selector">A descriptor to describe the mapping of our type</param>
		IPutMappingResponse Map<T>(Func<PutMappingDescriptor<T>, IPutMappingRequest> selector)
			where T : class;

		/// <inheritdoc />
		IPutMappingResponse Map(IPutMappingRequest request);

		/// <inheritdoc />
		Task<IPutMappingResponse> MapAsync<T>(Func<PutMappingDescriptor<T>, IPutMappingRequest> selector,
			CancellationToken ct = default
		)
			where T : class;

		/// <inheritdoc />
		Task<IPutMappingResponse> MapAsync(IPutMappingRequest request, CancellationToken ct = default);
	}

	public partial class ElasticClient
	{
		/// <inheritdoc />
		public IPutMappingResponse Map<T>(Func<PutMappingDescriptor<T>, IPutMappingRequest> selector)
			where T : class =>
			Map(selector?.Invoke(new PutMappingDescriptor<T>()));

		/// <inheritdoc />
		public IPutMappingResponse Map(IPutMappingRequest request) =>
			Dispatch2<IPutMappingRequest, PutMappingResponse>(request, request.RequestParameters);

		/// <inheritdoc />
		public Task<IPutMappingResponse> MapAsync<T>(
			Func<PutMappingDescriptor<T>, IPutMappingRequest> selector,
			CancellationToken ct = default
		)
			where T : class =>
			MapAsync(selector?.Invoke(new PutMappingDescriptor<T>()), ct);

		/// <inheritdoc />
		public Task<IPutMappingResponse> MapAsync(IPutMappingRequest request, CancellationToken ct = default) =>
			Dispatch2Async<IPutMappingRequest, IPutMappingResponse, PutMappingResponse>(request, request.RequestParameters, ct);
	}
}
