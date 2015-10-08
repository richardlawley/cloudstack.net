using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteBigSwitchBcfDeviceRequest : APIRequest
    {
        public DeleteBigSwitchBcfDeviceRequest() : base("deleteBigSwitchBcfDevice") {}

        /// <summary>
        /// BigSwitch device ID
        /// </summary>
        public Guid BigswitchBcfDeviceId { get; set; }

    }
    /// <summary>
    ///  delete a BigSwitch BCF Controller device
    /// </summary>
    /// <summary>
    ///  delete a BigSwitch BCF Controller device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteBigSwitchBcfDevice(DeleteBigSwitchBcfDeviceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteBigSwitchBcfDevice(DeleteBigSwitchBcfDeviceRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
