using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<string>(nameof(Hostname).ToLower()); }
            set { SetParameterValue(nameof(Hostname).ToLower(), value); }
        }

        /// <summary>
        /// Credentials to access the Nicira Controller API
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
        /// The Transportzone UUID configured on the Nicira Controller
        /// </summary>
        public string Transportzoneuuid {
            get { return GetParameterValue<string>(nameof(Transportzoneuuid).ToLower()); }
            set { SetParameterValue(nameof(Transportzoneuuid).ToLower(), value); }
        }

        /// <summary>
        /// Credentials to access the Nicira Controller API
        /// </summary>
        public string Username {
            get { return GetParameterValue<string>(nameof(Username).ToLower()); }
            set { SetParameterValue(nameof(Username).ToLower(), value); }
        }

        /// <summary>
        /// The L2 Gateway Service UUID configured on the Nicira Controller
        /// </summary>
        public string L2gatewayserviceuuid {
            get { return GetParameterValue<string>(nameof(L2gatewayserviceuuid).ToLower()); }
            set { SetParameterValue(nameof(L2gatewayserviceuuid).ToLower(), value); }
        }

        /// <summary>
        /// The L3 Gateway Service UUID configured on the Nicira Controller
        /// </summary>
        public string L3gatewayserviceuuid {
            get { return GetParameterValue<string>(nameof(L3gatewayserviceuuid).ToLower()); }
            set { SetParameterValue(nameof(L3gatewayserviceuuid).ToLower(), value); }
        }

    }
    /// <summary>
    /// Adds a Nicira NVP device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AddNiciraNvpDevice(AddNiciraNvpDeviceRequest request);
        Task<AsyncJobResponse> AddNiciraNvpDeviceAsync(AddNiciraNvpDeviceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AddNiciraNvpDevice(AddNiciraNvpDeviceRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> AddNiciraNvpDeviceAsync(AddNiciraNvpDeviceRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
