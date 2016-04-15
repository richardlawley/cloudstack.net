using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(LbRuleId).ToLower()); }
            set { SetParameterValue(nameof(LbRuleId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Removes a certificate from a load balancer rule
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse RemoveCertFromLoadBalancer(RemoveCertFromLoadBalancerRequest request);
        Task<AsyncJobResponse> RemoveCertFromLoadBalancerAsync(RemoveCertFromLoadBalancerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse RemoveCertFromLoadBalancer(RemoveCertFromLoadBalancerRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> RemoveCertFromLoadBalancerAsync(RemoveCertFromLoadBalancerRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
