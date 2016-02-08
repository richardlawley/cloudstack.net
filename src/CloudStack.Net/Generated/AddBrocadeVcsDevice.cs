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
            get { return (string) Parameters[nameof(Hostname).ToLower()]; }
            set { Parameters[nameof(Hostname).ToLower()] = value; }
        }

        /// <summary>
        /// Credentials to access the Brocade VCS Switch API
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
        /// Credentials to access the Brocade VCS Switch API
        /// </summary>
        public string Username {
            get { return (string) Parameters[nameof(Username).ToLower()]; }
            set { Parameters[nameof(Username).ToLower()] = value; }
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
