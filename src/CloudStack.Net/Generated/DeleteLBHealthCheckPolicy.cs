using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteLBHealthCheckPolicyRequest : APIRequest
    {
        public DeleteLBHealthCheckPolicyRequest() : base("deleteLBHealthCheckPolicy") {}

        /// <summary>
        /// the ID of the load balancer health check policy
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Deletes a load balancer health check policy.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteLBHealthCheckPolicy(DeleteLBHealthCheckPolicyRequest request);
        Task<AsyncJobResponse> DeleteLBHealthCheckPolicyAsync(DeleteLBHealthCheckPolicyRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteLBHealthCheckPolicy(DeleteLBHealthCheckPolicyRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteLBHealthCheckPolicyAsync(DeleteLBHealthCheckPolicyRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
