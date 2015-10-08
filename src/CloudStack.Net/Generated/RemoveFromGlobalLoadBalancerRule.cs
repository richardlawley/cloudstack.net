using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RemoveFromGlobalLoadBalancerRuleRequest : APIRequest
    {
        public RemoveFromGlobalLoadBalancerRuleRequest() : base("removeFromGlobalLoadBalancerRule") {}

        /// <summary>
        /// The ID of the load balancer rule
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// the list load balancer rules that will be assigned to gloabal load balancer rule
        /// </summary>
        public IList<long> LoadBalancerRulesIds { get; set; }

    }
    /// <summary>
    /// Removes a load balancer rule association with global load balancer rule
    /// </summary>
    /// <summary>
    /// Removes a load balancer rule association with global load balancer rule
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse RemoveFromGlobalLoadBalancerRule(RemoveFromGlobalLoadBalancerRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse RemoveFromGlobalLoadBalancerRule(RemoveFromGlobalLoadBalancerRuleRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
