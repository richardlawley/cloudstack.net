using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListNetscalerLoadBalancerNetworksRequest : APIRequest
    {
        public ListNetscalerLoadBalancerNetworksRequest() : base("listNetscalerLoadBalancerNetworks") {}

        /// <summary>
        /// netscaler load balancer device ID
        /// </summary>
        public Guid LbDeviceId { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

    }
    /// <summary>
    /// lists network that are using a netscaler load balancer device
    /// </summary>
    /// <summary>
    /// lists network that are using a netscaler load balancer device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<NetworkResponse> ListNetscalerLoadBalancerNetworks(ListNetscalerLoadBalancerNetworksRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<NetworkResponse> ListNetscalerLoadBalancerNetworks(ListNetscalerLoadBalancerNetworksRequest request) => _proxy.Request<ListResponse<NetworkResponse>>(request);
    }
}
