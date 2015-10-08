using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteNetworkDeviceRequest : APIRequest
    {
        public DeleteNetworkDeviceRequest() : base("deleteNetworkDevice") {}

        /// <summary>
        /// Id of network device to delete
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Deletes network device.
    /// </summary>
    /// <summary>
    /// Deletes network device.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteNetworkDevice(DeleteNetworkDeviceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteNetworkDevice(DeleteNetworkDeviceRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
