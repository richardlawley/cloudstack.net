using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteGlobalLoadBalancerRuleRequest : APIRequest
    {
        public DeleteGlobalLoadBalancerRuleRequest() : base("deleteGlobalLoadBalancerRule") {}

        /// <summary>
        /// the ID of the global load balancer rule
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Deletes a global load balancer rule.
    /// </summary>
    /// <summary>
    /// Deletes a global load balancer rule.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteGlobalLoadBalancerRule(DeleteGlobalLoadBalancerRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteGlobalLoadBalancerRule(DeleteGlobalLoadBalancerRuleRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
