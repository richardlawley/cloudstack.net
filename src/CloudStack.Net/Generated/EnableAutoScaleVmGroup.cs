using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Enables an AutoScale Vm Group
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse EnableAutoScaleVmGroup(EnableAutoScaleVmGroupRequest request);
        Task<AsyncJobResponse> EnableAutoScaleVmGroupAsync(EnableAutoScaleVmGroupRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse EnableAutoScaleVmGroup(EnableAutoScaleVmGroupRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> EnableAutoScaleVmGroupAsync(EnableAutoScaleVmGroupRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
