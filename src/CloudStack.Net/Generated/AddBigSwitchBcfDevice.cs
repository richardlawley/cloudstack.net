using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddBigSwitchBcfDeviceRequest : APIRequest
    {
        public AddBigSwitchBcfDeviceRequest() : base("addBigSwitchBcfDevice") {}

        /// <summary>
        /// Hostname of ip address of the BigSwitch BCF Controller.
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// NAT support of the BigSwitch BCF Controller.
        /// </summary>
        public bool Nat { get; set; }

        /// <summary>
        /// Password of the BigSwitch BCF Controller.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId { get; set; }

        /// <summary>
        /// Username of the BigSwitch BCF Controller.
        /// </summary>
        public string Username { get; set; }

    }
    /// <summary>
    /// Adds a BigSwitch BCF Controller device
    /// </summary>
    /// <summary>
    /// Adds a BigSwitch BCF Controller device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        BigSwitchBcfDeviceResponse AddBigSwitchBcfDevice(AddBigSwitchBcfDeviceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public BigSwitchBcfDeviceResponse AddBigSwitchBcfDevice(AddBigSwitchBcfDeviceRequest request) => _proxy.Request<BigSwitchBcfDeviceResponse>(request);
    }
}
