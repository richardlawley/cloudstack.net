using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Deletes a LB stickiness policy.
    /// </summary>
    /// <summary>
    /// Deletes a LB stickiness policy.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteLBStickinessPolicy(DeleteLBStickinessPolicyRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteLBStickinessPolicy(DeleteLBStickinessPolicyRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
