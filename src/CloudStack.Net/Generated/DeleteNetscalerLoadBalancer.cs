using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteNetscalerLoadBalancerRequest : APIRequest
    {
        public DeleteNetscalerLoadBalancerRequest() : base("deleteNetscalerLoadBalancer") {}

        /// <summary>
        /// netscaler load balancer device ID
        /// </summary>
        public Guid LbDeviceId { get; set; }

    }
    /// <summary>
    ///  delete a netscaler load balancer device
    /// </summary>
    /// <summary>
    ///  delete a netscaler load balancer device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteNetscalerLoadBalancer(DeleteNetscalerLoadBalancerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteNetscalerLoadBalancer(DeleteNetscalerLoadBalancerRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
