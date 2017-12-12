using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(LbDeviceId).ToLower()); }
            set { SetParameterValue(nameof(LbDeviceId).ToLower(), value); }
        }

        /// <summary>
        /// capacity of the device, Capacity will be interpreted as number of networks device can handle
        /// </summary>
        public long? Lbdevicecapacity {
            get { return GetParameterValue<long?>(nameof(Lbdevicecapacity).ToLower()); }
            set { SetParameterValue(nameof(Lbdevicecapacity).ToLower(), value); }
        }

    }
    /// <summary>
    /// configures a F5 load balancer device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ConfigureF5LoadBalancer(ConfigureF5LoadBalancerRequest request);
        Task<AsyncJobResponse> ConfigureF5LoadBalancerAsync(ConfigureF5LoadBalancerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ConfigureF5LoadBalancer(ConfigureF5LoadBalancerRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> ConfigureF5LoadBalancerAsync(ConfigureF5LoadBalancerRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
