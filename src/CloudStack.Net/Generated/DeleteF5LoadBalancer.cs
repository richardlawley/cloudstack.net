using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteF5LoadBalancerRequest : APIRequest
    {
        public DeleteF5LoadBalancerRequest() : base("deleteF5LoadBalancer") {}

        /// <summary>
        /// netscaler load balancer device ID
        /// </summary>
        public Guid LbDeviceId { get; set; }

    }
    /// <summary>
    ///  delete a F5 load balancer device
    /// </summary>
    /// <summary>
    ///  delete a F5 load balancer device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteF5LoadBalancer(DeleteF5LoadBalancerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteF5LoadBalancer(DeleteF5LoadBalancerRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
