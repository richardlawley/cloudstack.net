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
        public Guid LbRuleId { get; set; }

    }
    /// <summary>
    /// Removes a certificate from a load balancer rule
    /// </summary>
    /// <summary>
    /// Removes a certificate from a load balancer rule
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
