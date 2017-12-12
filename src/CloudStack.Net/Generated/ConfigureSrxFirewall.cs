using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ConfigureSrxFirewallRequest : APIRequest
    {
        public ConfigureSrxFirewallRequest() : base("configureSrxFirewall") {}

        /// <summary>
        /// SRX firewall device ID
        /// </summary>
        public Guid FwDeviceId {
            get { return GetParameterValue<Guid>(nameof(FwDeviceId).ToLower()); }
            set { SetParameterValue(nameof(FwDeviceId).ToLower(), value); }
        }

        /// <summary>
        /// capacity of the firewall device, Capacity will be interpreted as number of networks device can handle
        /// </summary>
        public long? Fwdevicecapacity {
            get { return GetParameterValue<long?>(nameof(Fwdevicecapacity).ToLower()); }
            set { SetParameterValue(nameof(Fwdevicecapacity).ToLower(), value); }
        }

    }
    /// <summary>
    /// Configures a SRX firewall device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ConfigureSrxFirewall(ConfigureSrxFirewallRequest request);
        Task<AsyncJobResponse> ConfigureSrxFirewallAsync(ConfigureSrxFirewallRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ConfigureSrxFirewall(ConfigureSrxFirewallRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> ConfigureSrxFirewallAsync(ConfigureSrxFirewallRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
