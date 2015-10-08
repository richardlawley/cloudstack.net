using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteLoadBalancerRequest : APIRequest
    {
        public DeleteLoadBalancerRequest() : base("deleteLoadBalancer") {}

        /// <summary>
        /// the ID of the Load Balancer
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Deletes a load balancer
    /// </summary>
    /// <summary>
    /// Deletes a load balancer
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteLoadBalancer(DeleteLoadBalancerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteLoadBalancer(DeleteLoadBalancerRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
