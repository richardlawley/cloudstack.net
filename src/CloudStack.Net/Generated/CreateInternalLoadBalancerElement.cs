using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (Guid) Parameters[nameof(NspId).ToLower()]; }
            set { Parameters[nameof(NspId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Create an Internal Load Balancer element.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateInternalLoadBalancerElement(CreateInternalLoadBalancerElementRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateInternalLoadBalancerElement(CreateInternalLoadBalancerElementRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
