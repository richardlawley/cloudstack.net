using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteAutoScaleVmGroupRequest : APIRequest
    {
        public DeleteAutoScaleVmGroupRequest() : base("deleteAutoScaleVmGroup") {}

        /// <summary>
        /// the ID of the autoscale group
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a autoscale vm group.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteAutoScaleVmGroup(DeleteAutoScaleVmGroupRequest request);
        Task<AsyncJobResponse> DeleteAutoScaleVmGroupAsync(DeleteAutoScaleVmGroupRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteAutoScaleVmGroup(DeleteAutoScaleVmGroupRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteAutoScaleVmGroupAsync(DeleteAutoScaleVmGroupRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
