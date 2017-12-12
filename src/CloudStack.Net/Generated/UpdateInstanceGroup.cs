using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// new instance group name
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates a vm group
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        InstanceGroupResponse UpdateInstanceGroup(UpdateInstanceGroupRequest request);
        Task<InstanceGroupResponse> UpdateInstanceGroupAsync(UpdateInstanceGroupRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public InstanceGroupResponse UpdateInstanceGroup(UpdateInstanceGroupRequest request) => Proxy.Request<InstanceGroupResponse>(request);
        public Task<InstanceGroupResponse> UpdateInstanceGroupAsync(UpdateInstanceGroupRequest request) => Proxy.RequestAsync<InstanceGroupResponse>(request);
    }
}
