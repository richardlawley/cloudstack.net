using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ConfigureF5LoadBalancerRequest : APIRequest
    {
        public ConfigureF5LoadBalancerRequest() : base("configureF5LoadBalancer") {}

        /// <summary>
        /// F5 load balancer device ID
        /// </summary>
        public Guid LbDeviceId {
            get { return (Guid) Parameters[nameof(LbDeviceId).ToLower()]; }
            set { Parameters[nameof(LbDeviceId).ToLower()] = value; }
        }

        /// <summary>
        /// capacity of the device, Capacity will be interpreted as number of networks device can handle
        /// </summary>
        public long? Lbdevicecapacity {
            get { return (long?) Parameters[nameof(Lbdevicecapacity).ToLower()]; }
            set { Parameters[nameof(Lbdevicecapacity).ToLower()] = value; }
        }

    }
    /// <summary>
    /// configures a F5 load balancer device
    /// </summary>
    /// <summary>
    /// configures a F5 load balancer device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        F5LoadBalancerResponse ConfigureF5LoadBalancer(ConfigureF5LoadBalancerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public F5LoadBalancerResponse ConfigureF5LoadBalancer(ConfigureF5LoadBalancerRequest request) => _proxy.Request<F5LoadBalancerResponse>(request);
    }
}
