using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RemoveFromGlobalLoadBalancerRuleRequest : APIRequest
    {
        public RemoveFromGlobalLoadBalancerRuleRequest() : base("removeFromGlobalLoadBalancerRule") {}

        /// <summary>
        /// The ID of the load balancer rule
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the list load balancer rules that will be assigned to gloabal load balancer rule
        /// </summary>
        public IList<Guid> Loadbalancerrulelist {
            get { return GetList<Guid>(nameof(Loadbalancerrulelist).ToLower()); }
            set { SetParameterValue(nameof(Loadbalancerrulelist).ToLower(), value); }
        }

    }
    /// <summary>
    /// Removes a load balancer rule association with global load balancer rule
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse RemoveFromGlobalLoadBalancerRule(RemoveFromGlobalLoadBalancerRuleRequest request);
        Task<AsyncJobResponse> RemoveFromGlobalLoadBalancerRuleAsync(RemoveFromGlobalLoadBalancerRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse RemoveFromGlobalLoadBalancerRule(RemoveFromGlobalLoadBalancerRuleRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> RemoveFromGlobalLoadBalancerRuleAsync(RemoveFromGlobalLoadBalancerRuleRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
