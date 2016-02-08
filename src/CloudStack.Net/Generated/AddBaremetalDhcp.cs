using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddBaremetalDhcpRequest : APIRequest
    {
        public AddBaremetalDhcpRequest() : base("addBaremetalDhcp") {}

        /// <summary>
        /// Type of dhcp device
        /// </summary>
        public string Dhcpservertype {
            get { return (string) Parameters[nameof(Dhcpservertype).ToLower()]; }
            set { Parameters[nameof(Dhcpservertype).ToLower()] = value; }
        }

        /// <summary>
        /// Credentials to reach external dhcp device
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
        /// URL of the external dhcp appliance.
        /// </summary>
        public string Url {
            get { return (string) Parameters[nameof(Url).ToLower()]; }
            set { Parameters[nameof(Url).ToLower()] = value; }
        }

        /// <summary>
        /// Credentials to reach external dhcp device
        /// </summary>
        public string Username {
            get { return (string) Parameters[nameof(Username).ToLower()]; }
            set { Parameters[nameof(Username).ToLower()] = value; }
        }

    }
    /// <summary>
    /// adds a baremetal dhcp server
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AddBaremetalDhcp(AddBaremetalDhcpRequest request);
        Task<AsyncJobResponse> AddBaremetalDhcpAsync(AddBaremetalDhcpRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AddBaremetalDhcp(AddBaremetalDhcpRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> AddBaremetalDhcpAsync(AddBaremetalDhcpRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
