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
        public Guid CertId {
            get { return (Guid) Parameters[nameof(CertId).ToLower()]; }
            set { Parameters[nameof(CertId).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the load balancer rule
        /// </summary>
        public Guid LbRuleId {
            get { return (Guid) Parameters[nameof(LbRuleId).ToLower()]; }
            set { Parameters[nameof(LbRuleId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Assigns a certificate to a load balancer rule
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AssignCertToLoadBalancer(AssignCertToLoadBalancerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AssignCertToLoadBalancer(AssignCertToLoadBalancerRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
