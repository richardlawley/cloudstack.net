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
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// the list load balancer rules that will be assigned to gloabal load balacner rule
        /// </summary>
        public IList<Guid> Loadbalancerrulelist {
            get { return (IList<Guid>) Parameters[nameof(Loadbalancerrulelist).ToLower()]; }
            set { Parameters[nameof(Loadbalancerrulelist).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Removes a load balancer rule association with global load balancer rule
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse RemoveFromGlobalLoadBalancerRule(RemoveFromGlobalLoadBalancerRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse RemoveFromGlobalLoadBalancerRule(RemoveFromGlobalLoadBalancerRuleRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
