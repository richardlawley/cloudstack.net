using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteNuageVspDeviceRequest : APIRequest
    {
        public DeleteNuageVspDeviceRequest() : base("deleteNuageVspDevice") {}

        /// <summary>
        /// Nuage device ID
        /// </summary>
        public Guid Vspdeviceid {
            get { return GetParameterValue<Guid>(nameof(Vspdeviceid).ToLower()); }
            set { SetParameterValue(nameof(Vspdeviceid).ToLower(), value); }
        }

    }
    /// <summary>
    /// delete a nuage vsp device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteNuageVspDevice(DeleteNuageVspDeviceRequest request);
        Task<AsyncJobResponse> DeleteNuageVspDeviceAsync(DeleteNuageVspDeviceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteNuageVspDevice(DeleteNuageVspDeviceRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteNuageVspDeviceAsync(DeleteNuageVspDeviceRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
