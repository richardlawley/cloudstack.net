using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ConfigureInternalLoadBalancerElementRequest : APIRequest
    {
        public ConfigureInternalLoadBalancerElementRequest() : base("configureInternalLoadBalancerElement") {}

        /// <summary>
        /// the ID of the internal lb provider
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// Enables/Disables the Internal Load Balancer element
        /// </summary>
        public bool Enabled {
            get { return GetParameterValue<bool>(nameof(Enabled).ToLower()); }
            set { SetParameterValue(nameof(Enabled).ToLower(), value); }
        }

    }
    /// <summary>
    /// Configures an Internal Load Balancer element.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ConfigureInternalLoadBalancerElement(ConfigureInternalLoadBalancerElementRequest request);
        Task<AsyncJobResponse> ConfigureInternalLoadBalancerElementAsync(ConfigureInternalLoadBalancerElementRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ConfigureInternalLoadBalancerElement(ConfigureInternalLoadBalancerElementRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> ConfigureInternalLoadBalancerElementAsync(ConfigureInternalLoadBalancerElementRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
