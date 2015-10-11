using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateLoadBalancerRuleRequest : APIRequest
    {
        public UpdateLoadBalancerRuleRequest() : base("updateLoadBalancerRule") {}

        /// <summary>
        /// the id of the load balancer rule to update
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// load balancer algorithm (source, roundrobin, leastconn)
        /// </summary>
        public string Algorithm {
            get { return (string) Parameters[nameof(Algorithm).ToLower()]; }
            set { Parameters[nameof(Algorithm).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId {
            get { return (string) Parameters[nameof(CustomId).ToLower()]; }
            set { Parameters[nameof(CustomId).ToLower()] = value; }
        }

        /// <summary>
        /// the description of the load balancer rule
        /// </summary>
        public string Description {
            get { return (string) Parameters[nameof(Description).ToLower()]; }
            set { Parameters[nameof(Description).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, whether to the display the rule to the end user or not
        /// </summary>
        public bool? Fordisplay {
            get { return (bool?) Parameters[nameof(Fordisplay).ToLower()]; }
            set { Parameters[nameof(Fordisplay).ToLower()] = value; }
        }

        /// <summary>
        /// the name of the load balancer rule
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Updates load balancer
    /// </summary>
    /// <summary>
    /// Updates load balancer
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        LoadBalancerResponse UpdateLoadBalancerRule(UpdateLoadBalancerRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public LoadBalancerResponse UpdateLoadBalancerRule(UpdateLoadBalancerRuleRequest request) => _proxy.Request<LoadBalancerResponse>(request);
    }
}
