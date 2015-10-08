using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListVirtualRouterElementsRequest : APIRequest
    {
        public ListVirtualRouterElementsRequest() : base("listVirtualRouterElements") {}

        /// <summary>
        /// list network offerings by enabled state
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// list virtual router elements by id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// list virtual router elements by network service provider id
        /// </summary>
        public Guid NspId { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

    }
    /// <summary>
    /// Lists all available virtual router elements.
    /// </summary>
    /// <summary>
    /// Lists all available virtual router elements.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<VirtualRouterProviderResponse> ListVirtualRouterElements(ListVirtualRouterElementsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<VirtualRouterProviderResponse> ListVirtualRouterElements(ListVirtualRouterElementsRequest request) => _proxy.Request<ListResponse<VirtualRouterProviderResponse>>(request);
    }
}
