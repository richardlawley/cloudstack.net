using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateLoadBalancerRuleRequest : APIRequest
    {
        public UpdateLoadBalancerRuleRequest() : base("updateLoadBalancerRule") {}

        /// <summary>
        /// the ID of the load balancer rule to update
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// load balancer algorithm (source, roundrobin, leastconn)
        /// </summary>
        public string Algorithm {
            get { return GetParameterValue<string>(nameof(Algorithm).ToLower()); }
            set { SetParameterValue(nameof(Algorithm).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId {
            get { return GetParameterValue<string>(nameof(CustomId).ToLower()); }
            set { SetParameterValue(nameof(CustomId).ToLower(), value); }
        }

        /// <summary>
        /// the description of the load balancer rule
        /// </summary>
        public string Description {
            get { return GetParameterValue<string>(nameof(Description).ToLower()); }
            set { SetParameterValue(nameof(Description).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, whether to the display the rule to the end user or not
        /// </summary>
        public bool? Fordisplay {
            get { return GetParameterValue<bool?>(nameof(Fordisplay).ToLower()); }
            set { SetParameterValue(nameof(Fordisplay).ToLower(), value); }
        }

        /// <summary>
        /// the name of the load balancer rule
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates load balancer
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdateLoadBalancerRule(UpdateLoadBalancerRuleRequest request);
        Task<AsyncJobResponse> UpdateLoadBalancerRuleAsync(UpdateLoadBalancerRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdateLoadBalancerRule(UpdateLoadBalancerRuleRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> UpdateLoadBalancerRuleAsync(UpdateLoadBalancerRuleRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
