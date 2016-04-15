using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteVolumeRequest : APIRequest
    {
        public DeleteVolumeRequest() : base("deleteVolume") {}

        /// <summary>
        /// The ID of the disk volume
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a detached disk volume.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteVolume(DeleteVolumeRequest request);
        Task<SuccessResponse> DeleteVolumeAsync(DeleteVolumeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteVolume(DeleteVolumeRequest request) => _proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteVolumeAsync(DeleteVolumeRequest request) => _proxy.RequestAsync<SuccessResponse>(request);
    }
}
