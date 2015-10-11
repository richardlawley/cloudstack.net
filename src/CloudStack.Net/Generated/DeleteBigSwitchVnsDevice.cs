using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteBigSwitchVnsDeviceRequest : APIRequest
    {
        public DeleteBigSwitchVnsDeviceRequest() : base("deleteBigSwitchVnsDevice") {}

        /// <summary>
        /// BigSwitch device ID
        /// </summary>
        public Guid Vnsdeviceid {
            get { return (Guid) Parameters[nameof(Vnsdeviceid).ToLower()]; }
            set { Parameters[nameof(Vnsdeviceid).ToLower()] = value; }
        }

    }
    /// <summary>
    ///  delete a bigswitch vns device
    /// </summary>
    /// <summary>
    ///  delete a bigswitch vns device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteBigSwitchVnsDevice(DeleteBigSwitchVnsDeviceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteBigSwitchVnsDevice(DeleteBigSwitchVnsDeviceRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
