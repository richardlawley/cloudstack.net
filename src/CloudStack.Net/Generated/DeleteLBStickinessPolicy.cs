using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteLBStickinessPolicyRequest : APIRequest
    {
        public DeleteLBStickinessPolicyRequest() : base("deleteLBStickinessPolicy") {}

        /// <summary>
        /// the ID of the LB stickiness policy
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a load balancer stickiness policy.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteLBStickinessPolicy(DeleteLBStickinessPolicyRequest request);
        Task<AsyncJobResponse> DeleteLBStickinessPolicyAsync(DeleteLBStickinessPolicyRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteLBStickinessPolicy(DeleteLBStickinessPolicyRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteLBStickinessPolicyAsync(DeleteLBStickinessPolicyRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
