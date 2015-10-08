using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateGlobalLoadBalancerRuleRequest : APIRequest
    {
        public UpdateGlobalLoadBalancerRuleRequest() : base("updateGlobalLoadBalancerRule") {}

        /// <summary>
        /// the ID of the global load balancer rule
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// the description of the load balancer rule
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// load balancer algorithm (roundrobin, leastconn, proximity) that is used to distributed traffic across the zones participating in global server load balancing, if not specified defaults to 'round robin'
        /// </summary>
        public string Algorithm { get; set; }

        /// <summary>
        /// session sticky method (sourceip) if not specified defaults to sourceip
        /// </summary>
        public string StickyMethod { get; set; }

    }
    /// <summary>
    /// update global load balancer rules.
    /// </summary>
    /// <summary>
    /// update global load balancer rules.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        GlobalLoadBalancerResponse UpdateGlobalLoadBalancerRule(UpdateGlobalLoadBalancerRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public GlobalLoadBalancerResponse UpdateGlobalLoadBalancerRule(UpdateGlobalLoadBalancerRuleRequest request) => _proxy.Request<GlobalLoadBalancerResponse>(request);
    }
}
