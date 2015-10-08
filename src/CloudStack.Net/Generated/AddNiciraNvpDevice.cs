using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddNiciraNvpDeviceRequest : APIRequest
    {
        public AddNiciraNvpDeviceRequest() : base("addNiciraNvpDevice") {}

        /// <summary>
        /// Hostname of ip address of the Nicira NVP Controller.
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// Credentials to access the Nicira Controller API
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId { get; set; }

        /// <summary>
        /// The Transportzone UUID configured on the Nicira Controller
        /// </summary>
        public string Transportzoneuuid { get; set; }

        /// <summary>
        /// Credentials to access the Nicira Controller API
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// The L3 Gateway Service UUID configured on the Nicira Controller
        /// </summary>
        public string L3gatewayserviceuuid { get; set; }

    }
    /// <summary>
    /// Adds a Nicira NVP device
    /// </summary>
    /// <summary>
    /// Adds a Nicira NVP device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        NiciraNvpDeviceResponse AddNiciraNvpDevice(AddNiciraNvpDeviceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public NiciraNvpDeviceResponse AddNiciraNvpDevice(AddNiciraNvpDeviceRequest request) => _proxy.Request<NiciraNvpDeviceResponse>(request);
    }
}
