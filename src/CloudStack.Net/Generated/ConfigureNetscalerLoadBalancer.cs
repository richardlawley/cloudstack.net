using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ConfigureNetscalerLoadBalancerRequest : APIRequest
    {
        public ConfigureNetscalerLoadBalancerRequest() : base("configureNetscalerLoadBalancer") {}

        /// <summary>
        /// Netscaler load balancer device ID
        /// </summary>
        public Guid LbDeviceId { get; set; }

        /// <summary>
        /// true if netscaler load balancer is intended to be used in in-line with firewall, false if netscaler load balancer will side-by-side with firewall
        /// </summary>
        public bool? Inline { get; set; }

        /// <summary>
        /// capacity of the device, Capacity will be interpreted as number of networks device can handle
        /// </summary>
        public long? Capacity { get; set; }

        /// <summary>
        /// true if this netscaler device to dedicated for a account, false if the netscaler device will be shared by multiple accounts
        /// </summary>
        public bool? DedicatedUse { get; set; }

        /// <summary>
        /// Used when NetScaler device is provider of EIP service. This parameter represents the list of pod's, for which there exists a policy based route on datacenter L3 router to route pod's subnet IP to a NetScaler device.
        /// </summary>
        public IList<long> PodIds { get; set; }

    }
    /// <summary>
    /// configures a netscaler load balancer device
    /// </summary>
    /// <summary>
    /// configures a netscaler load balancer device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        NetscalerLoadBalancerResponse ConfigureNetscalerLoadBalancer(ConfigureNetscalerLoadBalancerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public NetscalerLoadBalancerResponse ConfigureNetscalerLoadBalancer(ConfigureNetscalerLoadBalancerRequest request) => _proxy.Request<NetscalerLoadBalancerResponse>(request);
    }
}
