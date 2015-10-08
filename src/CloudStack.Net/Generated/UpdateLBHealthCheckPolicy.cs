using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateLBHealthCheckPolicyRequest : APIRequest
    {
        public UpdateLBHealthCheckPolicyRequest() : base("updateLBHealthCheckPolicy") {}

        /// <summary>
        /// ID of load balancer health check policy
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId { get; set; }

        /// <summary>
        /// an optional field, whether to the display the policy to the end user or not
        /// </summary>
        public bool? Display { get; set; }

    }
    /// <summary>
    /// Updates load balancer health check policy
    /// </summary>
    /// <summary>
    /// Updates load balancer health check policy
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        LBHealthCheckResponse UpdateLBHealthCheckPolicy(UpdateLBHealthCheckPolicyRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public LBHealthCheckResponse UpdateLBHealthCheckPolicy(UpdateLBHealthCheckPolicyRequest request) => _proxy.Request<LBHealthCheckResponse>(request);
    }
}
