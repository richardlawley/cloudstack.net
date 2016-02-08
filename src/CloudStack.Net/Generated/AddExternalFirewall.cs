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
            get { return (string) Parameters[nameof(Password).ToLower()]; }
            set { Parameters[nameof(Password).ToLower()] = value; }
        }

        /// <summary>
        /// URL of the external firewall appliance.
        /// </summary>
        public string Url {
            get { return (string) Parameters[nameof(Url).ToLower()]; }
            set { Parameters[nameof(Url).ToLower()] = value; }
        }

        /// <summary>
        /// Username of the external firewall appliance.
        /// </summary>
        public string Username {
            get { return (string) Parameters[nameof(Username).ToLower()]; }
            set { Parameters[nameof(Username).ToLower()] = value; }
        }

        /// <summary>
        /// Zone in which to add the external firewall appliance.
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
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
