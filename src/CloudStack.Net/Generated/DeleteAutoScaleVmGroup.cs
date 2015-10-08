using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteAutoScaleVmGroupRequest : APIRequest
    {
        public DeleteAutoScaleVmGroupRequest() : base("deleteAutoScaleVmGroup") {}

        /// <summary>
        /// the ID of the autoscale group
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Deletes a autoscale vm group.
    /// </summary>
    /// <summary>
    /// Deletes a autoscale vm group.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteAutoScaleVmGroup(DeleteAutoScaleVmGroupRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteAutoScaleVmGroup(DeleteAutoScaleVmGroupRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
