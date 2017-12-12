using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteF5LoadBalancerRequest : APIRequest
    {
        public DeleteF5LoadBalancerRequest() : base("deleteF5LoadBalancer") {}

        /// <summary>
        /// netscaler load balancer device ID
        /// </summary>
        public Guid LbDeviceId {
            get { return GetParameterValue<Guid>(nameof(LbDeviceId).ToLower()); }
            set { SetParameterValue(nameof(LbDeviceId).ToLower(), value); }
        }

    }
    /// <summary>
    ///  delete a F5 load balancer device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteF5LoadBalancer(DeleteF5LoadBalancerRequest request);
        Task<AsyncJobResponse> DeleteF5LoadBalancerAsync(DeleteF5LoadBalancerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteF5LoadBalancer(DeleteF5LoadBalancerRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteF5LoadBalancerAsync(DeleteF5LoadBalancerRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
