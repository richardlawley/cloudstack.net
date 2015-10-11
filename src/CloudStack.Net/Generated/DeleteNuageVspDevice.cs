using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (Guid) Parameters[nameof(Vspdeviceid).ToLower()]; }
            set { Parameters[nameof(Vspdeviceid).ToLower()] = value; }
        }

    }
    /// <summary>
    /// delete a nuage vsp device
    /// </summary>
    /// <summary>
    /// delete a nuage vsp device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteNuageVspDevice(DeleteNuageVspDeviceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteNuageVspDevice(DeleteNuageVspDeviceRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
