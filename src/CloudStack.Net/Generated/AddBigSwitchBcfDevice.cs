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
        public string Hostname {
            get { return (string) Parameters[nameof(Hostname).ToLower()]; }
            set { Parameters[nameof(Hostname).ToLower()] = value; }
        }

        /// <summary>
        /// NAT support of the BigSwitch BCF Controller.
        /// </summary>
        public bool Nat {
            get { return (bool) Parameters[nameof(Nat).ToLower()]; }
            set { Parameters[nameof(Nat).ToLower()] = value; }
        }

        /// <summary>
        /// Password of the BigSwitch BCF Controller.
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
        /// Username of the BigSwitch BCF Controller.
        /// </summary>
        public string Username {
            get { return (string) Parameters[nameof(Username).ToLower()]; }
            set { Parameters[nameof(Username).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Adds a BigSwitch BCF Controller device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AddBigSwitchBcfDevice(AddBigSwitchBcfDeviceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AddBigSwitchBcfDevice(AddBigSwitchBcfDeviceRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
