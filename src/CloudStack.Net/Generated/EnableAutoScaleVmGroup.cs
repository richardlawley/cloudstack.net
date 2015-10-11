using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class EnableAutoScaleVmGroupRequest : APIRequest
    {
        public EnableAutoScaleVmGroupRequest() : base("enableAutoScaleVmGroup") {}

        /// <summary>
        /// the ID of the autoscale group
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Enables an AutoScale Vm Group
    /// </summary>
    /// <summary>
    /// Enables an AutoScale Vm Group
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AutoScaleVmGroupResponse EnableAutoScaleVmGroup(EnableAutoScaleVmGroupRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AutoScaleVmGroupResponse EnableAutoScaleVmGroup(EnableAutoScaleVmGroupRequest request) => _proxy.Request<AutoScaleVmGroupResponse>(request);
    }
}
