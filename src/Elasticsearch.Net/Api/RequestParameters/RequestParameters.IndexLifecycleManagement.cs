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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

// ReSharper disable once CheckNamespace
namespace Elasticsearch.Net.Specification.IndexLifecycleManagementApi
{
	///<summary>Request options for DeleteLifecycle <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-delete-lifecycle.html</para></summary>
	public class DeleteLifecycleRequestParameters : RequestParameters<DeleteLifecycleRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.DELETE;
	}

	///<summary>Request options for ExplainLifecycle <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-explain-lifecycle.html</para></summary>
	public class ExplainLifecycleRequestParameters : RequestParameters<ExplainLifecycleRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
	}

	///<summary>Request options for GetLifecycle <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-get-lifecycle.html</para></summary>
	public class GetLifecycleRequestParameters : RequestParameters<GetLifecycleRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
	}

	///<summary>Request options for GetStatus <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-get-status.html</para></summary>
	public class GetIlmStatusRequestParameters : RequestParameters<GetIlmStatusRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
	}

	///<summary>Request options for MoveToStep <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-move-to-step.html</para></summary>
	public class MoveToStepRequestParameters : RequestParameters<MoveToStepRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
	}

	///<summary>Request options for PutLifecycle <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-put-lifecycle.html</para></summary>
	public class PutLifecycleRequestParameters : RequestParameters<PutLifecycleRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.PUT;
	}

	///<summary>Request options for RemovePolicy <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-remove-policy.html</para></summary>
	public class RemovePolicyRequestParameters : RequestParameters<RemovePolicyRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
	}

	///<summary>Request options for Retry <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-retry-policy.html</para></summary>
	public class RetryIlmRequestParameters : RequestParameters<RetryIlmRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
	}

	///<summary>Request options for Start <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-start.html</para></summary>
	public class StartIlmRequestParameters : RequestParameters<StartIlmRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
	}

	///<summary>Request options for Stop <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-stop.html</para></summary>
	public class StopIlmRequestParameters : RequestParameters<StopIlmRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
	}
}