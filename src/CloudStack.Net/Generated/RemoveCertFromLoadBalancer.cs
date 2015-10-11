using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RemoveCertFromLoadBalancerRequest : APIRequest
    {
        public RemoveCertFromLoadBalancerRequest() : base("removeCertFromLoadBalancer") {}

        /// <summary>
        /// the ID of the load balancer rule
        /// </summary>
        public Guid LbRuleId {
            get { return (Guid) Parameters[nameof(LbRuleId).ToLower()]; }
            set { Parameters[nameof(LbRuleId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Removes a certificate from a Load Balancer Rule
    /// </summary>
    /// <summary>
    /// Removes a certificate from a Load Balancer Rule
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse RemoveCertFromLoadBalancer(RemoveCertFromLoadBalancerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse RemoveCertFromLoadBalancer(RemoveCertFromLoadBalancerRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
