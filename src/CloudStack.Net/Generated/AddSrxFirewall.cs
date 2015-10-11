using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (string) Parameters[nameof(Networkdevicetype).ToLower()]; }
            set { Parameters[nameof(Networkdevicetype).ToLower()] = value; }
        }

        /// <summary>
        /// Credentials to reach SRX firewall device
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
        /// URL of the SRX appliance.
        /// </summary>
        public string Url {
            get { return (string) Parameters[nameof(Url).ToLower()]; }
            set { Parameters[nameof(Url).ToLower()] = value; }
        }

        /// <summary>
        /// Credentials to reach SRX firewall device
        /// </summary>
        public string Username {
            get { return (string) Parameters[nameof(Username).ToLower()]; }
            set { Parameters[nameof(Username).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Adds a SRX firewall device
    /// </summary>
    /// <summary>
    /// Adds a SRX firewall device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AddSrxFirewall(AddSrxFirewallRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AddSrxFirewall(AddSrxFirewallRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
