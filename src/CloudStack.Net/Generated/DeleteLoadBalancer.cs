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
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
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
        public AsyncJobResponse DeleteLoadBalancer(DeleteLoadBalancerRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteLoadBalancerAsync(DeleteLoadBalancerRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
