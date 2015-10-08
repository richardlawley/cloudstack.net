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
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Deletes a load balancer health check policy.
    /// </summary>
    /// <summary>
    /// Deletes a load balancer health check policy.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteLBHealthCheckPolicy(DeleteLBHealthCheckPolicyRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteLBHealthCheckPolicy(DeleteLBHealthCheckPolicyRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
