using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddExternalFirewallRequest : APIRequest
    {
        public AddExternalFirewallRequest() : base("addExternalFirewall") {}

        /// <summary>
        /// Password of the external firewall appliance.
        /// </summary>
        public string Password {
            get { return GetParameterValue<string>(nameof(Password).ToLower()); }
            set { SetParameterValue(nameof(Password).ToLower(), value); }
        }

        /// <summary>
        /// URL of the external firewall appliance.
        /// </summary>
        public string Url {
            get { return GetParameterValue<string>(nameof(Url).ToLower()); }
            set { SetParameterValue(nameof(Url).ToLower(), value); }
        }

        /// <summary>
        /// Username of the external firewall appliance.
        /// </summary>
        public string Username {
            get { return GetParameterValue<string>(nameof(Username).ToLower()); }
            set { SetParameterValue(nameof(Username).ToLower(), value); }
        }

        /// <summary>
        /// Zone in which to add the external firewall appliance.
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Adds an external firewall appliance
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ExternalFirewallResponse AddExternalFirewall(AddExternalFirewallRequest request);
        Task<ExternalFirewallResponse> AddExternalFirewallAsync(AddExternalFirewallRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ExternalFirewallResponse AddExternalFirewall(AddExternalFirewallRequest request) => _proxy.Request<ExternalFirewallResponse>(request);
        public Task<ExternalFirewallResponse> AddExternalFirewallAsync(AddExternalFirewallRequest request) => _proxy.RequestAsync<ExternalFirewallResponse>(request);
    }
}
