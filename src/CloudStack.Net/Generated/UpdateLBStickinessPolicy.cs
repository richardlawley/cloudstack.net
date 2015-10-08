using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateLBStickinessPolicyRequest : APIRequest
    {
        public UpdateLBStickinessPolicyRequest() : base("updateLBStickinessPolicy") {}

        /// <summary>
        /// id of lb stickiness policy
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
    /// Updates load balancer stickiness policy
    /// </summary>
    /// <summary>
    /// Updates load balancer stickiness policy
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        LBStickinessResponse UpdateLBStickinessPolicy(UpdateLBStickinessPolicyRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public LBStickinessResponse UpdateLBStickinessPolicy(UpdateLBStickinessPolicyRequest request) => _proxy.Request<LBStickinessResponse>(request);
    }
}
