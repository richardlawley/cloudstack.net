using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<string>(nameof(Hostname).ToLower()); }
            set { SetParameterValue(nameof(Hostname).ToLower(), value); }
        }

        /// <summary>
        /// NAT support of the BigSwitch BCF Controller.
        /// </summary>
        public bool Nat {
            get { return GetParameterValue<bool>(nameof(Nat).ToLower()); }
            set { SetParameterValue(nameof(Nat).ToLower(), value); }
        }

        /// <summary>
        /// Password of the BigSwitch BCF Controller.
        /// </summary>
        public string Password {
            get { return GetParameterValue<string>(nameof(Password).ToLower()); }
            set { SetParameterValue(nameof(Password).ToLower(), value); }
        }

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId {
            get { return GetParameterValue<Guid>(nameof(PhysicalNetworkId).ToLower()); }
            set { SetParameterValue(nameof(PhysicalNetworkId).ToLower(), value); }
        }

        /// <summary>
        /// Username of the BigSwitch BCF Controller.
        /// </summary>
        public string Username {
            get { return GetParameterValue<string>(nameof(Username).ToLower()); }
            set { SetParameterValue(nameof(Username).ToLower(), value); }
        }

    }
    /// <summary>
    /// Adds a BigSwitch BCF Controller device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AddBigSwitchBcfDevice(AddBigSwitchBcfDeviceRequest request);
        Task<AsyncJobResponse> AddBigSwitchBcfDeviceAsync(AddBigSwitchBcfDeviceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AddBigSwitchBcfDevice(AddBigSwitchBcfDeviceRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> AddBigSwitchBcfDeviceAsync(AddBigSwitchBcfDeviceRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
