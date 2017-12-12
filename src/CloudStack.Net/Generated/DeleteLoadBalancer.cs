using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteLoadBalancerRequest : APIRequest
    {
        public DeleteLoadBalancerRequest() : base("deleteLoadBalancer") {}

        /// <summary>
        /// the ID of the Load Balancer
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a load balancer
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteLoadBalancer(DeleteLoadBalancerRequest request);
        Task<AsyncJobResponse> DeleteLoadBalancerAsync(DeleteLoadBalancerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteLoadBalancer(DeleteLoadBalancerRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteLoadBalancerAsync(DeleteLoadBalancerRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
