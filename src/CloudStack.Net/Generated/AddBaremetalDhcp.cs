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
            get { return GetParameterValue<string>(nameof(Dhcpservertype).ToLower()); }
            set { SetParameterValue(nameof(Dhcpservertype).ToLower(), value); }
        }

        /// <summary>
        /// Credentials to reach external dhcp device
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
        /// URL of the external dhcp appliance.
        /// </summary>
        public string Url {
            get { return GetParameterValue<string>(nameof(Url).ToLower()); }
            set { SetParameterValue(nameof(Url).ToLower(), value); }
        }

        /// <summary>
        /// Credentials to reach external dhcp device
        /// </summary>
        public string Username {
            get { return GetParameterValue<string>(nameof(Username).ToLower()); }
            set { SetParameterValue(nameof(Username).ToLower(), value); }
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
