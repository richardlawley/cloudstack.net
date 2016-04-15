using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddBrocadeVcsDeviceRequest : APIRequest
    {
        public AddBrocadeVcsDeviceRequest() : base("addBrocadeVcsDevice") {}

        /// <summary>
        /// Hostname of ip address of the Brocade VCS Switch.
        /// </summary>
        public string Hostname {
            get { return GetParameterValue<string>(nameof(Hostname).ToLower()); }
            set { SetParameterValue(nameof(Hostname).ToLower(), value); }
        }

        /// <summary>
        /// Credentials to access the Brocade VCS Switch API
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
        /// Credentials to access the Brocade VCS Switch API
        /// </summary>
        public string Username {
            get { return GetParameterValue<string>(nameof(Username).ToLower()); }
            set { SetParameterValue(nameof(Username).ToLower(), value); }
        }

    }
    /// <summary>
    /// Adds a Brocade VCS Switch
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AddBrocadeVcsDevice(AddBrocadeVcsDeviceRequest request);
        Task<AsyncJobResponse> AddBrocadeVcsDeviceAsync(AddBrocadeVcsDeviceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AddBrocadeVcsDevice(AddBrocadeVcsDeviceRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> AddBrocadeVcsDeviceAsync(AddBrocadeVcsDeviceRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
