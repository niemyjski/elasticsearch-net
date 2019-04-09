﻿using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Elasticsearch.Net;

namespace Nest
{
	using IndexTemplateExistConverter = Func<IApiCallDetails, Stream, ExistsResponse>;

	public partial interface IElasticClient
	{
		/// <inheritdoc />
		IExistsResponse IndexTemplateExists(Name template, Func<IndexTemplateExistsDescriptor, IIndexTemplateExistsRequest> selector = null);

		/// <inheritdoc />
		IExistsResponse IndexTemplateExists(IIndexTemplateExistsRequest request);

		/// <inheritdoc />
		Task<IExistsResponse> IndexTemplateExistsAsync(Name template,
			Func<IndexTemplateExistsDescriptor, IIndexTemplateExistsRequest> selector = null,
			CancellationToken cancellationToken = default
		);

		/// <inheritdoc />
		Task<IExistsResponse> IndexTemplateExistsAsync(IIndexTemplateExistsRequest request,
			CancellationToken ct = default
		);
	}

	public partial class ElasticClient
	{
		/// <inheritdoc />
		public IExistsResponse IndexTemplateExists(Name template, Func<IndexTemplateExistsDescriptor, IIndexTemplateExistsRequest> selector = null) =>
			IndexTemplateExists(selector.InvokeOrDefault(new IndexTemplateExistsDescriptor(template)));

		/// <inheritdoc />
		public IExistsResponse IndexTemplateExists(IIndexTemplateExistsRequest request) =>
			Dispatch2<IIndexTemplateExistsRequest, ExistsResponse>(request, request.RequestParameters);

		/// <inheritdoc />
		public Task<IExistsResponse> IndexTemplateExistsAsync(Name template,
			Func<IndexTemplateExistsDescriptor, IIndexTemplateExistsRequest> selector = null,
			CancellationToken cancellationToken = default
		) =>
			IndexTemplateExistsAsync(selector.InvokeOrDefault(new IndexTemplateExistsDescriptor(template)), cancellationToken);

		/// <inheritdoc />
		public Task<IExistsResponse> IndexTemplateExistsAsync(IIndexTemplateExistsRequest request, CancellationToken ct = default) =>
			Dispatch2Async<IIndexTemplateExistsRequest, IExistsResponse, ExistsResponse>(request, request.RequestParameters, ct);
	}
}
