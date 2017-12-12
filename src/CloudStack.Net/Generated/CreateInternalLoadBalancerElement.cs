using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateInternalLoadBalancerElementRequest : APIRequest
    {
        public CreateInternalLoadBalancerElementRequest() : base("createInternalLoadBalancerElement") {}

        /// <summary>
        /// the network service provider ID of the internal load balancer element
        /// </summary>
        public Guid NspId {
            get { return GetParameterValue<Guid>(nameof(NspId).ToLower()); }
            set { SetParameterValue(nameof(NspId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Create an Internal Load Balancer element.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateInternalLoadBalancerElement(CreateInternalLoadBalancerElementRequest request);
        Task<AsyncJobResponse> CreateInternalLoadBalancerElementAsync(CreateInternalLoadBalancerElementRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateInternalLoadBalancerElement(CreateInternalLoadBalancerElementRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateInternalLoadBalancerElementAsync(CreateInternalLoadBalancerElementRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
