using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteLBHealthCheckPolicy(DeleteLBHealthCheckPolicyRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
