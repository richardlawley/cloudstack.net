using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListNetworkServiceProvidersRequest : APIListRequest
    {
        public ListNetworkServiceProvidersRequest() : base("listNetworkServiceProviders") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// list providers by name
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid? PhysicalNetworkId {
            get { return GetParameterValue<Guid?>(nameof(PhysicalNetworkId).ToLower()); }
            set { SetParameterValue(nameof(PhysicalNetworkId).ToLower(), value); }
        }

        /// <summary>
        /// list providers by state
        /// </summary>
        public string State {
            get { return GetParameterValue<string>(nameof(State).ToLower()); }
            set { SetParameterValue(nameof(State).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists network serviceproviders for a given physical network.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ProviderResponse> ListNetworkServiceProviders(ListNetworkServiceProvidersRequest request);
        Task<ListResponse<ProviderResponse>> ListNetworkServiceProvidersAsync(ListNetworkServiceProvidersRequest request);
        ListResponse<ProviderResponse> ListNetworkServiceProvidersAllPages(ListNetworkServiceProvidersRequest request);
        Task<ListResponse<ProviderResponse>> ListNetworkServiceProvidersAllPagesAsync(ListNetworkServiceProvidersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ProviderResponse> ListNetworkServiceProviders(ListNetworkServiceProvidersRequest request) => _proxy.Request<ListResponse<ProviderResponse>>(request);
        public Task<ListResponse<ProviderResponse>> ListNetworkServiceProvidersAsync(ListNetworkServiceProvidersRequest request) => _proxy.RequestAsync<ListResponse<ProviderResponse>>(request);
        public ListResponse<ProviderResponse> ListNetworkServiceProvidersAllPages(ListNetworkServiceProvidersRequest request) => _proxy.RequestAllPages<ProviderResponse>(request);
        public Task<ListResponse<ProviderResponse>> ListNetworkServiceProvidersAllPagesAsync(ListNetworkServiceProvidersRequest request) => _proxy.RequestAllPagesAsync<ProviderResponse>(request);
    }
}
