using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListTrafficTypesRequest : APIListRequest
    {
        public ListTrafficTypesRequest() : base("listTrafficTypes") {}

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId {
            get { return (Guid) Parameters[nameof(PhysicalNetworkId).ToLower()]; }
            set { Parameters[nameof(PhysicalNetworkId).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists traffic types of a given physical network.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ProviderResponse> ListTrafficTypes(ListTrafficTypesRequest request);
        Task<ListResponse<ProviderResponse>> ListTrafficTypesAsync(ListTrafficTypesRequest request);
        ListResponse<ProviderResponse> ListTrafficTypesAllPages(ListTrafficTypesRequest request);
        Task<ListResponse<ProviderResponse>> ListTrafficTypesAllPagesAsync(ListTrafficTypesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ProviderResponse> ListTrafficTypes(ListTrafficTypesRequest request) => _proxy.Request<ListResponse<ProviderResponse>>(request);
        public Task<ListResponse<ProviderResponse>> ListTrafficTypesAsync(ListTrafficTypesRequest request) => _proxy.RequestAsync<ListResponse<ProviderResponse>>(request);
        public ListResponse<ProviderResponse> ListTrafficTypesAllPages(ListTrafficTypesRequest request) => _proxy.RequestAllPages<ProviderResponse>(request);
        public Task<ListResponse<ProviderResponse>> ListTrafficTypesAllPagesAsync(ListTrafficTypesRequest request) => _proxy.RequestAllPagesAsync<ProviderResponse>(request);
    }
}
