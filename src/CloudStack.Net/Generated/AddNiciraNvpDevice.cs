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
        public string Hostname {
            get { return (string) Parameters[nameof(Hostname).ToLower()]; }
            set { Parameters[nameof(Hostname).ToLower()] = value; }
        }

        /// <summary>
        /// Credentials to access the Nicira Controller API
        /// </summary>
        public string Password {
            get { return (string) Parameters[nameof(Password).ToLower()]; }
            set { Parameters[nameof(Password).ToLower()] = value; }
        }

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId {
            get { return (Guid) Parameters[nameof(PhysicalNetworkId).ToLower()]; }
            set { Parameters[nameof(PhysicalNetworkId).ToLower()] = value; }
        }

        /// <summary>
        /// The Transportzone UUID configured on the Nicira Controller
        /// </summary>
        public string Transportzoneuuid {
            get { return (string) Parameters[nameof(Transportzoneuuid).ToLower()]; }
            set { Parameters[nameof(Transportzoneuuid).ToLower()] = value; }
        }

        /// <summary>
        /// Credentials to access the Nicira Controller API
        /// </summary>
        public string Username {
            get { return (string) Parameters[nameof(Username).ToLower()]; }
            set { Parameters[nameof(Username).ToLower()] = value; }
        }

        /// <summary>
        /// The L3 Gateway Service UUID configured on the Nicira Controller
        /// </summary>
        public string L3gatewayserviceuuid {
            get { return (string) Parameters[nameof(L3gatewayserviceuuid).ToLower()]; }
            set { Parameters[nameof(L3gatewayserviceuuid).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Adds a Nicira NVP device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AddNiciraNvpDevice(AddNiciraNvpDeviceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AddNiciraNvpDevice(AddNiciraNvpDeviceRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
