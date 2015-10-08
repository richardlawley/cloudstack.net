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
        public string DeviceType { get; set; }

        /// <summary>
        /// Credentials to reach SRX firewall device
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId { get; set; }

        /// <summary>
        /// URL of the SRX appliance.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Credentials to reach SRX firewall device
        /// </summary>
        public string Username { get; set; }

    }
    /// <summary>
    /// Adds a SRX firewall device
    /// </summary>
    /// <summary>
    /// Adds a SRX firewall device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SrxFirewallResponse AddSrxFirewall(AddSrxFirewallRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SrxFirewallResponse AddSrxFirewall(AddSrxFirewallRequest request) => _proxy.Request<SrxFirewallResponse>(request);
    }
}
