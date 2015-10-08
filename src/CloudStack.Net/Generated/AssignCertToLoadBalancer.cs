using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AssignCertToLoadBalancerRequest : APIRequest
    {
        public AssignCertToLoadBalancerRequest() : base("assignCertToLoadBalancer") {}

        /// <summary>
        /// the ID of the certificate
        /// </summary>
        public Guid CertId { get; set; }

        /// <summary>
        /// the ID of the load balancer rule
        /// </summary>
        public Guid LbRuleId { get; set; }

    }
    /// <summary>
    /// Assigns a certificate to a load balancer rule
    /// </summary>
    /// <summary>
    /// Assigns a certificate to a load balancer rule
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse AssignCertToLoadBalancer(AssignCertToLoadBalancerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse AssignCertToLoadBalancer(AssignCertToLoadBalancerRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
