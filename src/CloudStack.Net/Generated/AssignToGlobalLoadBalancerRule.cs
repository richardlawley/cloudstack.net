using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AssignToGlobalLoadBalancerRuleRequest : APIRequest
    {
        public AssignToGlobalLoadBalancerRuleRequest() : base("assignToGlobalLoadBalancerRule") {}

        /// <summary>
        /// the ID of the global load balancer rule
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// the list load balancer rules that will be assigned to global load balancer rule
        /// </summary>
        public IList<long> LoadBalancerRulesIds { get; set; }

        /// <summary>
        /// Map of LB rule id's and corresponding weights (between 1-100) in the GSLB rule, if not specified weight of a LB rule is defaulted to 1. Specified as 'gslblbruleweightsmap[0].loadbalancerid=UUID&gslblbruleweightsmap[0].weight=10'
        /// </summary>
        public IDictionary<string, string> GslbLbRuleWieghtMap { get; set; }

    }
    /// <summary>
    /// Assign load balancer rule or list of load balancer rules to a global load balancer rules.
    /// </summary>
    /// <summary>
    /// Assign load balancer rule or list of load balancer rules to a global load balancer rules.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse AssignToGlobalLoadBalancerRule(AssignToGlobalLoadBalancerRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse AssignToGlobalLoadBalancerRule(AssignToGlobalLoadBalancerRuleRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
