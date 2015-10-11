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
        public Guid LbDeviceId {
            get { return (Guid) Parameters[nameof(LbDeviceId).ToLower()]; }
            set { Parameters[nameof(LbDeviceId).ToLower()] = value; }
        }

        /// <summary>
        /// true if netscaler load balancer is intended to be used in in-line with firewall, false if netscaler load balancer will side-by-side with firewall
        /// </summary>
        public bool? Inline {
            get { return (bool?) Parameters[nameof(Inline).ToLower()]; }
            set { Parameters[nameof(Inline).ToLower()] = value; }
        }

        /// <summary>
        /// capacity of the device, Capacity will be interpreted as number of networks device can handle
        /// </summary>
        public long? Lbdevicecapacity {
            get { return (long?) Parameters[nameof(Lbdevicecapacity).ToLower()]; }
            set { Parameters[nameof(Lbdevicecapacity).ToLower()] = value; }
        }

        /// <summary>
        /// true if this netscaler device to dedicated for a account, false if the netscaler device will be shared by multiple accounts
        /// </summary>
        public bool? Lbdevicededicated {
            get { return (bool?) Parameters[nameof(Lbdevicededicated).ToLower()]; }
            set { Parameters[nameof(Lbdevicededicated).ToLower()] = value; }
        }

        /// <summary>
        /// Used when NetScaler device is provider of EIP service. This parameter represents the list of pod's, for which there exists a policy based route on datacenter L3 router to route pod's subnet IP to a NetScaler device.
        /// </summary>
        public IList<Guid> PodIds {
            get { return (IList<Guid>) Parameters[nameof(PodIds).ToLower()]; }
            set { Parameters[nameof(PodIds).ToLower()] = value; }
        }

    }
    /// <summary>
    /// configures a netscaler load balancer device
    /// </summary>
    /// <summary>
    /// configures a netscaler load balancer device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ConfigureNetscalerLoadBalancer(ConfigureNetscalerLoadBalancerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ConfigureNetscalerLoadBalancer(ConfigureNetscalerLoadBalancerRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
