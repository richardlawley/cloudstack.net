using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteNiciraNvpDeviceRequest : APIRequest
    {
        public DeleteNiciraNvpDeviceRequest() : base("deleteNiciraNvpDevice") {}

        /// <summary>
        /// Nicira device ID
        /// </summary>
        public Guid NiciraNvpDeviceId { get; set; }

    }
    /// <summary>
    ///  delete a nicira nvp device
    /// </summary>
    /// <summary>
    ///  delete a nicira nvp device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteNiciraNvpDevice(DeleteNiciraNvpDeviceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteNiciraNvpDevice(DeleteNiciraNvpDeviceRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
