using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddPaloAltoFirewallRequest : APIRequest
    {
        public AddPaloAltoFirewallRequest() : base("addPaloAltoFirewall") {}

        /// <summary>
        /// supports only PaloAltoFirewall
        /// </summary>
        public string Networkdevicetype {
            get { return GetParameterValue<string>(nameof(Networkdevicetype).ToLower()); }
            set { SetParameterValue(nameof(Networkdevicetype).ToLower(), value); }
        }

        /// <summary>
        /// Credentials to reach Palo Alto firewall device
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
        /// URL of the Palo Alto appliance.
        /// </summary>
        public string Url {
            get { return GetParameterValue<string>(nameof(Url).ToLower()); }
            set { SetParameterValue(nameof(Url).ToLower(), value); }
        }

        /// <summary>
        /// Credentials to reach Palo Alto firewall device
        /// </summary>
        public string Username {
            get { return GetParameterValue<string>(nameof(Username).ToLower()); }
            set { SetParameterValue(nameof(Username).ToLower(), value); }
        }

    }
    /// <summary>
    /// Adds a Palo Alto firewall device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AddPaloAltoFirewall(AddPaloAltoFirewallRequest request);
        Task<AsyncJobResponse> AddPaloAltoFirewallAsync(AddPaloAltoFirewallRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AddPaloAltoFirewall(AddPaloAltoFirewallRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> AddPaloAltoFirewallAsync(AddPaloAltoFirewallRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
