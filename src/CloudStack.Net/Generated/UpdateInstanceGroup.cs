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
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// new instance group name
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

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
