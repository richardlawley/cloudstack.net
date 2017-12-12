using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListSupportedNetworkServicesRequest : APIListRequest
    {
        public ListSupportedNetworkServicesRequest() : base("listSupportedNetworkServices") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// network service provider name
        /// </summary>
        public string Provider {
            get { return GetParameterValue<string>(nameof(Provider).ToLower()); }
            set { SetParameterValue(nameof(Provider).ToLower(), value); }
        }

        /// <summary>
        /// network service name to list providers and capabilities of
        /// </summary>
        public string Service {
            get { return GetParameterValue<string>(nameof(Service).ToLower()); }
            set { SetParameterValue(nameof(Service).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists all network services provided by CloudStack or for the given Provider.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ServiceResponse> ListSupportedNetworkServices(ListSupportedNetworkServicesRequest request);
        Task<ListResponse<ServiceResponse>> ListSupportedNetworkServicesAsync(ListSupportedNetworkServicesRequest request);
        ListResponse<ServiceResponse> ListSupportedNetworkServicesAllPages(ListSupportedNetworkServicesRequest request);
        Task<ListResponse<ServiceResponse>> ListSupportedNetworkServicesAllPagesAsync(ListSupportedNetworkServicesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ServiceResponse> ListSupportedNetworkServices(ListSupportedNetworkServicesRequest request) => Proxy.Request<ListResponse<ServiceResponse>>(request);
        public Task<ListResponse<ServiceResponse>> ListSupportedNetworkServicesAsync(ListSupportedNetworkServicesRequest request) => Proxy.RequestAsync<ListResponse<ServiceResponse>>(request);
        public ListResponse<ServiceResponse> ListSupportedNetworkServicesAllPages(ListSupportedNetworkServicesRequest request) => Proxy.RequestAllPages<ServiceResponse>(request);
        public Task<ListResponse<ServiceResponse>> ListSupportedNetworkServicesAllPagesAsync(ListSupportedNetworkServicesRequest request) => Proxy.RequestAllPagesAsync<ServiceResponse>(request);
    }
}
