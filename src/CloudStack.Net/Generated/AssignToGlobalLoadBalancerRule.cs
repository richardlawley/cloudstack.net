using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AssignToGlobalLoadBalancerRuleRequest : APIRequest
    {
        public AssignToGlobalLoadBalancerRuleRequest() : base("assignToGlobalLoadBalancerRule") {}

        /// <summary>
        /// the ID of the global load balancer rule
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the list load balancer rules that will be assigned to global load balancer rule
        /// </summary>
        public IList<Guid> Loadbalancerrulelist {
            get { return GetList<Guid>(nameof(Loadbalancerrulelist).ToLower()); }
            set { SetParameterValue(nameof(Loadbalancerrulelist).ToLower(), value); }
        }

        /// <summary>
        /// Map of LB rule id's and corresponding weights (between 1-100) in the GSLB rule, if not specified weight of a LB rule is defaulted to 1. Specified as 'gslblbruleweightsmap[0].loadbalancerid=UUID&gslblbruleweightsmap[0].weight=10'
        /// </summary>
        public IList<IDictionary<string, object>> Gslblbruleweightsmap {
            get { return GetList<IDictionary<string, object>>(nameof(Gslblbruleweightsmap).ToLower()); }
            set { SetParameterValue(nameof(Gslblbruleweightsmap).ToLower(), value); }
        }

    }
    /// <summary>
    /// Assign load balancer rule or list of load balancer rules to a global load balancer rules.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AssignToGlobalLoadBalancerRule(AssignToGlobalLoadBalancerRuleRequest request);
        Task<AsyncJobResponse> AssignToGlobalLoadBalancerRuleAsync(AssignToGlobalLoadBalancerRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AssignToGlobalLoadBalancerRule(AssignToGlobalLoadBalancerRuleRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> AssignToGlobalLoadBalancerRuleAsync(AssignToGlobalLoadBalancerRuleRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
