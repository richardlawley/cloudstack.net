using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddSrxFirewallRequest : APIRequest
    {
        public AddSrxFirewallRequest() : base("addSrxFirewall") {}

        /// <summary>
        /// supports only JuniperSRXFirewall
        /// </summary>
        public string Networkdevicetype {
            get { return GetParameterValue<string>(nameof(Networkdevicetype).ToLower()); }
            set { SetParameterValue(nameof(Networkdevicetype).ToLower(), value); }
        }

        /// <summary>
        /// Credentials to reach SRX firewall device
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
        /// URL of the SRX appliance.
        /// </summary>
        public string Url {
            get { return GetParameterValue<string>(nameof(Url).ToLower()); }
            set { SetParameterValue(nameof(Url).ToLower(), value); }
        }

        /// <summary>
        /// Credentials to reach SRX firewall device
        /// </summary>
        public string Username {
            get { return GetParameterValue<string>(nameof(Username).ToLower()); }
            set { SetParameterValue(nameof(Username).ToLower(), value); }
        }

    }
    /// <summary>
    /// Adds a SRX firewall device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AddSrxFirewall(AddSrxFirewallRequest request);
        Task<AsyncJobResponse> AddSrxFirewallAsync(AddSrxFirewallRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AddSrxFirewall(AddSrxFirewallRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> AddSrxFirewallAsync(AddSrxFirewallRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
