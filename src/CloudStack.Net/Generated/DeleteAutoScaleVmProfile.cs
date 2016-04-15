using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteAutoScaleVmProfileRequest : APIRequest
    {
        public DeleteAutoScaleVmProfileRequest() : base("deleteAutoScaleVmProfile") {}

        /// <summary>
        /// the ID of the autoscale profile
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a autoscale vm profile.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteAutoScaleVmProfile(DeleteAutoScaleVmProfileRequest request);
        Task<AsyncJobResponse> DeleteAutoScaleVmProfileAsync(DeleteAutoScaleVmProfileRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteAutoScaleVmProfile(DeleteAutoScaleVmProfileRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteAutoScaleVmProfileAsync(DeleteAutoScaleVmProfileRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
