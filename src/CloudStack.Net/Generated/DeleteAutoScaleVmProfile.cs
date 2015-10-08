using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteAutoScaleVmProfileRequest : APIRequest
    {
        public DeleteAutoScaleVmProfileRequest() : base("deleteAutoScaleVmProfile") {}

        /// <summary>
        /// the ID of the autoscale profile
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Deletes a autoscale vm profile.
    /// </summary>
    /// <summary>
    /// Deletes a autoscale vm profile.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteAutoScaleVmProfile(DeleteAutoScaleVmProfileRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteAutoScaleVmProfile(DeleteAutoScaleVmProfileRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
