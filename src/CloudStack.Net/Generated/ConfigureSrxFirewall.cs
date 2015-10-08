using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ConfigureSrxFirewallRequest : APIRequest
    {
        public ConfigureSrxFirewallRequest() : base("configureSrxFirewall") {}

        /// <summary>
        /// SRX firewall device ID
        /// </summary>
        public Guid FwDeviceId { get; set; }

        /// <summary>
        /// capacity of the firewall device, Capacity will be interpreted as number of networks device can handle
        /// </summary>
        public long? Capacity { get; set; }

    }
    /// <summary>
    /// Configures a SRX firewall device
    /// </summary>
    /// <summary>
    /// Configures a SRX firewall device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SrxFirewallResponse ConfigureSrxFirewall(ConfigureSrxFirewallRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SrxFirewallResponse ConfigureSrxFirewall(ConfigureSrxFirewallRequest request) => _proxy.Request<SrxFirewallResponse>(request);
    }
}
