using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteAutoScalePolicyRequest : APIRequest
    {
        public DeleteAutoScalePolicyRequest() : base("deleteAutoScalePolicy") {}

        /// <summary>
        /// the ID of the autoscale policy
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Deletes a autoscale policy.
    /// </summary>
    /// <summary>
    /// Deletes a autoscale policy.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteAutoScalePolicy(DeleteAutoScalePolicyRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteAutoScalePolicy(DeleteAutoScalePolicyRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
