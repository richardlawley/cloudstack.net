using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ConfigureNetscalerLoadBalancerRequest : APIRequest
    {
        public ConfigureNetscalerLoadBalancerRequest() : base("configureNetscalerLoadBalancer") {}

        /// <summary>
        /// Netscaler load balancer device ID
        /// </summary>
        public Guid LbDeviceId {
            get { return GetParameterValue<Guid>(nameof(LbDeviceId).ToLower()); }
            set { SetParameterValue(nameof(LbDeviceId).ToLower(), value); }
        }

        /// <summary>
        /// true if netscaler load balancer is intended to be used in in-line with firewall, false if netscaler load balancer will side-by-side with firewall
        /// </summary>
        public bool? Inline {
            get { return GetParameterValue<bool?>(nameof(Inline).ToLower()); }
            set { SetParameterValue(nameof(Inline).ToLower(), value); }
        }

        /// <summary>
        /// capacity of the device, Capacity will be interpreted as number of networks device can handle
        /// </summary>
        public long? Lbdevicecapacity {
            get { return GetParameterValue<long?>(nameof(Lbdevicecapacity).ToLower()); }
            set { SetParameterValue(nameof(Lbdevicecapacity).ToLower(), value); }
        }

        /// <summary>
        /// true if this netscaler device to dedicated for a account, false if the netscaler device will be shared by multiple accounts
        /// </summary>
        public bool? Lbdevicededicated {
            get { return GetParameterValue<bool?>(nameof(Lbdevicededicated).ToLower()); }
            set { SetParameterValue(nameof(Lbdevicededicated).ToLower(), value); }
        }

        /// <summary>
        /// Used when NetScaler device is provider of EIP service. This parameter represents the list of pod's, for which there exists a policy based route on datacenter L3 router to route pod's subnet IP to a NetScaler device.
        /// </summary>
        public IList<Guid> PodIds {
            get { return GetList<Guid>(nameof(PodIds).ToLower()); }
            set { SetParameterValue(nameof(PodIds).ToLower(), value); }
        }

    }
    /// <summary>
    /// configures a netscaler load balancer device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ConfigureNetscalerLoadBalancer(ConfigureNetscalerLoadBalancerRequest request);
        Task<AsyncJobResponse> ConfigureNetscalerLoadBalancerAsync(ConfigureNetscalerLoadBalancerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ConfigureNetscalerLoadBalancer(ConfigureNetscalerLoadBalancerRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> ConfigureNetscalerLoadBalancerAsync(ConfigureNetscalerLoadBalancerRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
