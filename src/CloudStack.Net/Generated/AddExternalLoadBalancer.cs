using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddExternalLoadBalancerRequest : APIRequest
    {
        public AddExternalLoadBalancerRequest() : base("addExternalLoadBalancer") {}

        /// <summary>
        /// Password of the external load balancer appliance.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// URL of the external load balancer appliance.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Username of the external load balancer appliance.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Zone in which to add the external load balancer appliance.
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// Adds F5 external load balancer appliance.
    /// </summary>
    /// <summary>
    /// Adds F5 external load balancer appliance.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ExternalLoadBalancerResponse AddExternalLoadBalancer(AddExternalLoadBalancerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ExternalLoadBalancerResponse AddExternalLoadBalancer(AddExternalLoadBalancerRequest request) => _proxy.Request<ExternalLoadBalancerResponse>(request);
    }
}
