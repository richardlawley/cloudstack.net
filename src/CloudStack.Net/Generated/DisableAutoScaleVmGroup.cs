using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DisableAutoScaleVmGroupRequest : APIRequest
    {
        public DisableAutoScaleVmGroupRequest() : base("disableAutoScaleVmGroup") {}

        /// <summary>
        /// the ID of the autoscale group
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Disables an AutoScale Vm Group
    /// </summary>
    /// <summary>
    /// Disables an AutoScale Vm Group
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AutoScaleVmGroupResponse DisableAutoScaleVmGroup(DisableAutoScaleVmGroupRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AutoScaleVmGroupResponse DisableAutoScaleVmGroup(DisableAutoScaleVmGroupRequest request) => _proxy.Request<AutoScaleVmGroupResponse>(request);
    }
}
