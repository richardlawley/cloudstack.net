using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateLoadBalancerRuleRequest : APIRequest
    {
        public UpdateLoadBalancerRuleRequest() : base("updateLoadBalancerRule") {}

        /// <summary>
        /// the ID of the load balancer rule to update
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// load balancer algorithm (source, roundrobin, leastconn)
        /// </summary>
        public string Algorithm { get; set; }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId { get; set; }

        /// <summary>
        /// the description of the load balancer rule
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// an optional field, whether to the display the rule to the end user or not
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// the name of the load balancer rule
        /// </summary>
        public string LoadBalancerName { get; set; }

    }
    /// <summary>
    /// Updates load balancer
    /// </summary>
    /// <summary>
    /// Updates load balancer
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        LoadBalancerResponse UpdateLoadBalancerRule(UpdateLoadBalancerRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public LoadBalancerResponse UpdateLoadBalancerRule(UpdateLoadBalancerRuleRequest request) => _proxy.Request<LoadBalancerResponse>(request);
    }
}
