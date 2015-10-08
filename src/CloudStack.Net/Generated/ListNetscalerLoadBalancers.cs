using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListNetscalerLoadBalancersRequest : APIRequest
    {
        public ListNetscalerLoadBalancersRequest() : base("listNetscalerLoadBalancers") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// netscaler load balancer device ID
        /// </summary>
        public Guid LbDeviceId { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId { get; set; }

    }
    /// <summary>
    /// lists netscaler load balancer devices
    /// </summary>
    /// <summary>
    /// lists netscaler load balancer devices
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<NetscalerLoadBalancerResponse> ListNetscalerLoadBalancers(ListNetscalerLoadBalancersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<NetscalerLoadBalancerResponse> ListNetscalerLoadBalancers(ListNetscalerLoadBalancersRequest request) => _proxy.Request<ListResponse<NetscalerLoadBalancerResponse>>(request);
    }
}
