using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListF5LoadBalancerNetworksRequest : APIRequest
    {
        public ListF5LoadBalancerNetworksRequest() : base("listF5LoadBalancerNetworks") {}

        /// <summary>
        /// f5 load balancer device ID
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
    /// lists network that are using a F5 load balancer device
    /// </summary>
    /// <summary>
    /// lists network that are using a F5 load balancer device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<NetworkResponse> ListF5LoadBalancerNetworks(ListF5LoadBalancerNetworksRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<NetworkResponse> ListF5LoadBalancerNetworks(ListF5LoadBalancerNetworksRequest request) => _proxy.Request<ListResponse<NetworkResponse>>(request);
    }
}
