using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteNetscalerLoadBalancerRequest : APIRequest
    {
        public DeleteNetscalerLoadBalancerRequest() : base("deleteNetscalerLoadBalancer") {}

        /// <summary>
        /// netscaler load balancer device ID
        /// </summary>
        public Guid LbDeviceId {
            get { return GetParameterValue<Guid>(nameof(LbDeviceId).ToLower()); }
            set { SetParameterValue(nameof(LbDeviceId).ToLower(), value); }
        }

    }
    /// <summary>
    ///  delete a netscaler load balancer device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteNetscalerLoadBalancer(DeleteNetscalerLoadBalancerRequest request);
        Task<AsyncJobResponse> DeleteNetscalerLoadBalancerAsync(DeleteNetscalerLoadBalancerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteNetscalerLoadBalancer(DeleteNetscalerLoadBalancerRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteNetscalerLoadBalancerAsync(DeleteNetscalerLoadBalancerRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
