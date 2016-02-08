using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DisableAutoScaleVmGroupRequest : APIRequest
    {
        public DisableAutoScaleVmGroupRequest() : base("disableAutoScaleVmGroup") {}

        /// <summary>
        /// the ID of the autoscale group
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Disables an AutoScale Vm Group
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DisableAutoScaleVmGroup(DisableAutoScaleVmGroupRequest request);
        Task<AsyncJobResponse> DisableAutoScaleVmGroupAsync(DisableAutoScaleVmGroupRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DisableAutoScaleVmGroup(DisableAutoScaleVmGroupRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DisableAutoScaleVmGroupAsync(DisableAutoScaleVmGroupRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
