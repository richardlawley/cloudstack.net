using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(CertId).ToLower()); }
            set { SetParameterValue(nameof(CertId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the load balancer rule
        /// </summary>
        public Guid LbRuleId {
            get { return GetParameterValue<Guid>(nameof(LbRuleId).ToLower()); }
            set { SetParameterValue(nameof(LbRuleId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Assigns a certificate to a load balancer rule
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AssignCertToLoadBalancer(AssignCertToLoadBalancerRequest request);
        Task<AsyncJobResponse> AssignCertToLoadBalancerAsync(AssignCertToLoadBalancerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AssignCertToLoadBalancer(AssignCertToLoadBalancerRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> AssignCertToLoadBalancerAsync(AssignCertToLoadBalancerRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
