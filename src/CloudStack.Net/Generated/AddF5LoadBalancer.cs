using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddF5LoadBalancerRequest : APIRequest
    {
        public AddF5LoadBalancerRequest() : base("addF5LoadBalancer") {}

        /// <summary>
        /// supports only F5BigIpLoadBalancer
        /// </summary>
        public string DeviceType { get; set; }

        /// <summary>
        /// Credentials to reach F5 BigIP load balancer device
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId { get; set; }

        /// <summary>
        /// URL of the F5 load balancer appliance.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Credentials to reach F5 BigIP load balancer device
        /// </summary>
        public string Username { get; set; }

    }
    /// <summary>
    /// Adds a F5 BigIP load balancer device
    /// </summary>
    /// <summary>
    /// Adds a F5 BigIP load balancer device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        F5LoadBalancerResponse AddF5LoadBalancer(AddF5LoadBalancerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public F5LoadBalancerResponse AddF5LoadBalancer(AddF5LoadBalancerRequest request) => _proxy.Request<F5LoadBalancerResponse>(request);
    }
}
