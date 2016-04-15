using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateGlobalLoadBalancerRuleRequest : APIRequest
    {
        public UpdateGlobalLoadBalancerRuleRequest() : base("updateGlobalLoadBalancerRule") {}

        /// <summary>
        /// the ID of the global load balancer rule
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the description of the load balancer rule
        /// </summary>
        public string Description {
            get { return GetParameterValue<string>(nameof(Description).ToLower()); }
            set { SetParameterValue(nameof(Description).ToLower(), value); }
        }

        /// <summary>
        /// load balancer algorithm (roundrobin, leastconn, proximity) that is used to distributed traffic across the zones participating in global server load balancing, if not specified defaults to 'round robin'
        /// </summary>
        public string Gslblbmethod {
            get { return GetParameterValue<string>(nameof(Gslblbmethod).ToLower()); }
            set { SetParameterValue(nameof(Gslblbmethod).ToLower(), value); }
        }

        /// <summary>
        /// session sticky method (sourceip) if not specified defaults to sourceip
        /// </summary>
        public string Gslbstickysessionmethodname {
            get { return GetParameterValue<string>(nameof(Gslbstickysessionmethodname).ToLower()); }
            set { SetParameterValue(nameof(Gslbstickysessionmethodname).ToLower(), value); }
        }

    }
    /// <summary>
    /// update global load balancer rules.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdateGlobalLoadBalancerRule(UpdateGlobalLoadBalancerRuleRequest request);
        Task<AsyncJobResponse> UpdateGlobalLoadBalancerRuleAsync(UpdateGlobalLoadBalancerRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdateGlobalLoadBalancerRule(UpdateGlobalLoadBalancerRuleRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> UpdateGlobalLoadBalancerRuleAsync(UpdateGlobalLoadBalancerRuleRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
