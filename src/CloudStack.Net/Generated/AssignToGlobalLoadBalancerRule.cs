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
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// the list load balancer rules that will be assigned to gloabal load balacner rule
        /// </summary>
        public IList<Guid> Loadbalancerrulelist {
            get { return GetList<Guid>(nameof(Loadbalancerrulelist).ToLower()); }
            set { Parameters[nameof(Loadbalancerrulelist).ToLower()] = value; }
        }

        /// <summary>
        /// Map of LB rule id's and corresponding weights (between 1-100) in the GSLB rule, if not specified weight of a LB rule is defaulted to 1. Specified as 'gslblbruleweightsmap[0].loadbalancerid=UUID&gslblbruleweightsmap[0].weight=10'
        /// </summary>
        public IList<IDictionary<string, object>> Gslblbruleweightsmap {
            get { return GetList<IDictionary<string, object>>(nameof(Gslblbruleweightsmap).ToLower()); }
            set { Parameters[nameof(Gslblbruleweightsmap).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Assign load balancer rule or list of load balancer rules to a global load balancer rules.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AssignToGlobalLoadBalancerRule(AssignToGlobalLoadBalancerRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AssignToGlobalLoadBalancerRule(AssignToGlobalLoadBalancerRuleRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
