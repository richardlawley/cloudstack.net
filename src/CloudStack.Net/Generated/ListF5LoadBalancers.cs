using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListF5LoadBalancersRequest : APIRequest
    {
        public ListF5LoadBalancersRequest() : base("listF5LoadBalancers") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// f5 load balancer device ID
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
    /// lists F5 load balancer devices
    /// </summary>
    /// <summary>
    /// lists F5 load balancer devices
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<F5LoadBalancerResponse> ListF5LoadBalancers(ListF5LoadBalancersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<F5LoadBalancerResponse> ListF5LoadBalancers(ListF5LoadBalancersRequest request) => _proxy.Request<ListResponse<F5LoadBalancerResponse>>(request);
    }
}
