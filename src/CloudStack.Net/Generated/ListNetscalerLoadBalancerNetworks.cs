using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListNetscalerLoadBalancerNetworksRequest : APIListRequest
    {
        public ListNetscalerLoadBalancerNetworksRequest() : base("listNetscalerLoadBalancerNetworks") {}

        /// <summary>
        /// netscaler load balancer device ID
        /// </summary>
        public Guid LbDeviceId {
            get { return GetParameterValue<Guid>(nameof(LbDeviceId).ToLower()); }
            set { SetParameterValue(nameof(LbDeviceId).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

    }
    /// <summary>
    /// lists network that are using a netscaler load balancer device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<NetworkResponse> ListNetscalerLoadBalancerNetworks(ListNetscalerLoadBalancerNetworksRequest request);
        Task<ListResponse<NetworkResponse>> ListNetscalerLoadBalancerNetworksAsync(ListNetscalerLoadBalancerNetworksRequest request);
        ListResponse<NetworkResponse> ListNetscalerLoadBalancerNetworksAllPages(ListNetscalerLoadBalancerNetworksRequest request);
        Task<ListResponse<NetworkResponse>> ListNetscalerLoadBalancerNetworksAllPagesAsync(ListNetscalerLoadBalancerNetworksRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<NetworkResponse> ListNetscalerLoadBalancerNetworks(ListNetscalerLoadBalancerNetworksRequest request) => Proxy.Request<ListResponse<NetworkResponse>>(request);
        public Task<ListResponse<NetworkResponse>> ListNetscalerLoadBalancerNetworksAsync(ListNetscalerLoadBalancerNetworksRequest request) => Proxy.RequestAsync<ListResponse<NetworkResponse>>(request);
        public ListResponse<NetworkResponse> ListNetscalerLoadBalancerNetworksAllPages(ListNetscalerLoadBalancerNetworksRequest request) => Proxy.RequestAllPages<NetworkResponse>(request);
        public Task<ListResponse<NetworkResponse>> ListNetscalerLoadBalancerNetworksAllPagesAsync(ListNetscalerLoadBalancerNetworksRequest request) => Proxy.RequestAllPagesAsync<NetworkResponse>(request);
    }
}
