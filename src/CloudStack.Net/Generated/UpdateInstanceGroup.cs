using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateInstanceGroupRequest : APIRequest
    {
        public UpdateInstanceGroupRequest() : base("updateInstanceGroup") {}

        /// <summary>
        /// Instance group ID
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// new instance group name
        /// </summary>
        public string GroupName { get; set; }

    }
    /// <summary>
    /// Updates a vm group
    /// </summary>
    /// <summary>
    /// Updates a vm group
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        InstanceGroupResponse UpdateInstanceGroup(UpdateInstanceGroupRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public InstanceGroupResponse UpdateInstanceGroup(UpdateInstanceGroupRequest request) => _proxy.Request<InstanceGroupResponse>(request);
    }
}
