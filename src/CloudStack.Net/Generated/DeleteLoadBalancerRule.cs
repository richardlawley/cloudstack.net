using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteLoadBalancerRuleRequest : APIRequest
    {
        public DeleteLoadBalancerRuleRequest() : base("deleteLoadBalancerRule") {}

        /// <summary>
        /// the ID of the load balancer rule
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Deletes a load balancer rule.
    /// </summary>
    /// <summary>
    /// Deletes a load balancer rule.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteLoadBalancerRule(DeleteLoadBalancerRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteLoadBalancerRule(DeleteLoadBalancerRuleRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
