using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ConfigurePaloAltoFirewallRequest : APIRequest
    {
        public ConfigurePaloAltoFirewallRequest() : base("configurePaloAltoFirewall") {}

        /// <summary>
        /// Palo Alto firewall device ID
        /// </summary>
        public Guid FwDeviceId {
            get { return (Guid) Parameters[nameof(FwDeviceId).ToLower()]; }
            set { Parameters[nameof(FwDeviceId).ToLower()] = value; }
        }

        /// <summary>
        /// capacity of the firewall device, Capacity will be interpreted as number of networks device can handle
        /// </summary>
        public long? Fwdevicecapacity {
            get { return (long?) Parameters[nameof(Fwdevicecapacity).ToLower()]; }
            set { Parameters[nameof(Fwdevicecapacity).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Configures a Palo Alto firewall device
    /// </summary>
    /// <summary>
    /// Configures a Palo Alto firewall device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        PaloAltoFirewallResponse ConfigurePaloAltoFirewall(ConfigurePaloAltoFirewallRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public PaloAltoFirewallResponse ConfigurePaloAltoFirewall(ConfigurePaloAltoFirewallRequest request) => _proxy.Request<PaloAltoFirewallResponse>(request);
    }
}
