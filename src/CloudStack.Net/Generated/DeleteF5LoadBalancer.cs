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
        public Guid LbDeviceId {
            get { return (Guid) Parameters[nameof(LbDeviceId).ToLower()]; }
            set { Parameters[nameof(LbDeviceId).ToLower()] = value; }
        }

    }
    /// <summary>
    ///  delete a F5 load balancer device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteF5LoadBalancer(DeleteF5LoadBalancerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteF5LoadBalancer(DeleteF5LoadBalancerRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
