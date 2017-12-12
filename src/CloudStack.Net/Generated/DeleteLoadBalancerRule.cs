using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteLoadBalancerRuleRequest : APIRequest
    {
        public DeleteLoadBalancerRuleRequest() : base("deleteLoadBalancerRule") {}

        /// <summary>
        /// the ID of the load balancer rule
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a load balancer rule.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteLoadBalancerRule(DeleteLoadBalancerRuleRequest request);
        Task<AsyncJobResponse> DeleteLoadBalancerRuleAsync(DeleteLoadBalancerRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteLoadBalancerRule(DeleteLoadBalancerRuleRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteLoadBalancerRuleAsync(DeleteLoadBalancerRuleRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
