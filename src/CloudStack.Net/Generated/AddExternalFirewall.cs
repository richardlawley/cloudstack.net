using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddExternalFirewallRequest : APIRequest
    {
        public AddExternalFirewallRequest() : base("addExternalFirewall") {}

        /// <summary>
        /// Password of the external firewall appliance.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// URL of the external firewall appliance.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Username of the external firewall appliance.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Zone in which to add the external firewall appliance.
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// Adds an external firewall appliance
    /// </summary>
    /// <summary>
    /// Adds an external firewall appliance
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ExternalFirewallResponse AddExternalFirewall(AddExternalFirewallRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ExternalFirewallResponse AddExternalFirewall(AddExternalFirewallRequest request) => _proxy.Request<ExternalFirewallResponse>(request);
    }
}
