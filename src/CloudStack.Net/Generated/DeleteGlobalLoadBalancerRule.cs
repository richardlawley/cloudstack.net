using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteGlobalLoadBalancerRuleRequest : APIRequest
    {
        public DeleteGlobalLoadBalancerRuleRequest() : base("deleteGlobalLoadBalancerRule") {}

        /// <summary>
        /// the ID of the global load balancer rule
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Deletes a global load balancer rule.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteGlobalLoadBalancerRule(DeleteGlobalLoadBalancerRuleRequest request);
        Task<AsyncJobResponse> DeleteGlobalLoadBalancerRuleAsync(DeleteGlobalLoadBalancerRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteGlobalLoadBalancerRule(DeleteGlobalLoadBalancerRuleRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteGlobalLoadBalancerRuleAsync(DeleteGlobalLoadBalancerRuleRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
