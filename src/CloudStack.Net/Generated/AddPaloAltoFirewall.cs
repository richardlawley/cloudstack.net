using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddPaloAltoFirewallRequest : APIRequest
    {
        public AddPaloAltoFirewallRequest() : base("addPaloAltoFirewall") {}

        /// <summary>
        /// supports only PaloAltoFirewall
        /// </summary>
        public string DeviceType { get; set; }

        /// <summary>
        /// Credentials to reach Palo Alto firewall device
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId { get; set; }

        /// <summary>
        /// URL of the Palo Alto appliance.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Credentials to reach Palo Alto firewall device
        /// </summary>
        public string Username { get; set; }

    }
    /// <summary>
    /// Adds a Palo Alto firewall device
    /// </summary>
    /// <summary>
    /// Adds a Palo Alto firewall device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        PaloAltoFirewallResponse AddPaloAltoFirewall(AddPaloAltoFirewallRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public PaloAltoFirewallResponse AddPaloAltoFirewall(AddPaloAltoFirewallRequest request) => _proxy.Request<PaloAltoFirewallResponse>(request);
    }
}
