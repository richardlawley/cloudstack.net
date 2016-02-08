using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteNiciraNvpDeviceRequest : APIRequest
    {
        public DeleteNiciraNvpDeviceRequest() : base("deleteNiciraNvpDevice") {}

        /// <summary>
        /// Nicira device ID
        /// </summary>
        public Guid Nvpdeviceid {
            get { return (Guid) Parameters[nameof(Nvpdeviceid).ToLower()]; }
            set { Parameters[nameof(Nvpdeviceid).ToLower()] = value; }
        }

    }
    /// <summary>
    ///  delete a nicira nvp device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteNiciraNvpDevice(DeleteNiciraNvpDeviceRequest request);
        Task<AsyncJobResponse> DeleteNiciraNvpDeviceAsync(DeleteNiciraNvpDeviceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteNiciraNvpDevice(DeleteNiciraNvpDeviceRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteNiciraNvpDeviceAsync(DeleteNiciraNvpDeviceRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
