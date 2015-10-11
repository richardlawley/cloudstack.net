using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddBigSwitchVnsDeviceRequest : APIRequest
    {
        public AddBigSwitchVnsDeviceRequest() : base("addBigSwitchVnsDevice") {}

        /// <summary>
        /// Hostname of ip address of the BigSwitch VNS Controller.
        /// </summary>
        public string Hostname {
            get { return (string) Parameters[nameof(Hostname).ToLower()]; }
            set { Parameters[nameof(Hostname).ToLower()] = value; }
        }

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId {
            get { return (Guid) Parameters[nameof(PhysicalNetworkId).ToLower()]; }
            set { Parameters[nameof(PhysicalNetworkId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Adds a BigSwitch VNS device
    /// </summary>
    /// <summary>
    /// Adds a BigSwitch VNS device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        BigSwitchVnsDeviceResponse AddBigSwitchVnsDevice(AddBigSwitchVnsDeviceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public BigSwitchVnsDeviceResponse AddBigSwitchVnsDevice(AddBigSwitchVnsDeviceRequest request) => _proxy.Request<BigSwitchVnsDeviceResponse>(request);
    }
}
