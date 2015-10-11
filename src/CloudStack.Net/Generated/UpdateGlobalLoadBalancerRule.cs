using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// the description of the load balancer rule
        /// </summary>
        public string Description {
            get { return (string) Parameters[nameof(Description).ToLower()]; }
            set { Parameters[nameof(Description).ToLower()] = value; }
        }

        /// <summary>
        /// load balancer algorithm (roundrobin, leastconn, proximity) that is used to distributed traffic across the zones participating in global server load balancing, if not specified defaults to 'round robin'
        /// </summary>
        public string Gslblbmethod {
            get { return (string) Parameters[nameof(Gslblbmethod).ToLower()]; }
            set { Parameters[nameof(Gslblbmethod).ToLower()] = value; }
        }

        /// <summary>
        /// session sticky method (sourceip) if not specified defaults to sourceip
        /// </summary>
        public string Gslbstickysessionmethodname {
            get { return (string) Parameters[nameof(Gslbstickysessionmethodname).ToLower()]; }
            set { Parameters[nameof(Gslbstickysessionmethodname).ToLower()] = value; }
        }

    }
    /// <summary>
    /// update global load balancer rules.
    /// </summary>
    /// <summary>
    /// update global load balancer rules.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdateGlobalLoadBalancerRule(UpdateGlobalLoadBalancerRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdateGlobalLoadBalancerRule(UpdateGlobalLoadBalancerRuleRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
