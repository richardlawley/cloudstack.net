using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListVirtualRouterElementsRequest : APIRequest
    {
        public ListVirtualRouterElementsRequest() : base("listVirtualRouterElements") {}

        /// <summary>
        /// list network offerings by enabled state
        /// </summary>
        public bool? Enabled {
            get { return (bool?) Parameters[nameof(Enabled).ToLower()]; }
            set { Parameters[nameof(Enabled).ToLower()] = value; }
        }

        /// <summary>
        /// list virtual router elements by id
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        /// <summary>
        /// list virtual router elements by network service provider id
        /// </summary>
        public Guid NspId {
            get { return (Guid) Parameters[nameof(NspId).ToLower()]; }
            set { Parameters[nameof(NspId).ToLower()] = value; }
        }

        public int? Page {
            get { return (int?) Parameters[nameof(Page).ToLower()]; }
            set { Parameters[nameof(Page).ToLower()] = value; }
        }

        public int? PageSize {
            get { return (int?) Parameters[nameof(PageSize).ToLower()]; }
            set { Parameters[nameof(PageSize).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists all available virtual router elements.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<VirtualRouterProviderResponse> ListVirtualRouterElements(ListVirtualRouterElementsRequest request);
        Task<ListResponse<VirtualRouterProviderResponse>> ListVirtualRouterElementsAsync(ListVirtualRouterElementsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<VirtualRouterProviderResponse> ListVirtualRouterElements(ListVirtualRouterElementsRequest request) => _proxy.Request<ListResponse<VirtualRouterProviderResponse>>(request);
        public Task<ListResponse<VirtualRouterProviderResponse>> ListVirtualRouterElementsAsync(ListVirtualRouterElementsRequest request) => _proxy.RequestAsync<ListResponse<VirtualRouterProviderResponse>>(request);
    }
}
