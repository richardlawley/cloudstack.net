using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListVirtualRouterElementsRequest : APIListRequest
    {
        public ListVirtualRouterElementsRequest() : base("listVirtualRouterElements") {}

        /// <summary>
        /// list network offerings by enabled state
        /// </summary>
        public bool? Enabled {
            get { return GetParameterValue<bool?>(nameof(Enabled).ToLower()); }
            set { SetParameterValue(nameof(Enabled).ToLower(), value); }
        }

        /// <summary>
        /// list virtual router elements by id
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// list virtual router elements by network service provider id
        /// </summary>
        public Guid? NspId {
            get { return GetParameterValue<Guid?>(nameof(NspId).ToLower()); }
            set { SetParameterValue(nameof(NspId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists all available virtual router elements.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<VirtualRouterProviderResponse> ListVirtualRouterElements(ListVirtualRouterElementsRequest request);
        Task<ListResponse<VirtualRouterProviderResponse>> ListVirtualRouterElementsAsync(ListVirtualRouterElementsRequest request);
        ListResponse<VirtualRouterProviderResponse> ListVirtualRouterElementsAllPages(ListVirtualRouterElementsRequest request);
        Task<ListResponse<VirtualRouterProviderResponse>> ListVirtualRouterElementsAllPagesAsync(ListVirtualRouterElementsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<VirtualRouterProviderResponse> ListVirtualRouterElements(ListVirtualRouterElementsRequest request) => _proxy.Request<ListResponse<VirtualRouterProviderResponse>>(request);
        public Task<ListResponse<VirtualRouterProviderResponse>> ListVirtualRouterElementsAsync(ListVirtualRouterElementsRequest request) => _proxy.RequestAsync<ListResponse<VirtualRouterProviderResponse>>(request);
        public ListResponse<VirtualRouterProviderResponse> ListVirtualRouterElementsAllPages(ListVirtualRouterElementsRequest request) => _proxy.RequestAllPages<VirtualRouterProviderResponse>(request);
        public Task<ListResponse<VirtualRouterProviderResponse>> ListVirtualRouterElementsAllPagesAsync(ListVirtualRouterElementsRequest request) => _proxy.RequestAllPagesAsync<VirtualRouterProviderResponse>(request);
    }
}
