using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteExternalLoadBalancerRequest : APIRequest
    {
        public DeleteExternalLoadBalancerRequest() : base("deleteExternalLoadBalancer") {}

        /// <summary>
        /// Id of the external loadbalancer appliance.
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Deletes a F5 external load balancer appliance added in a zone.
    /// </summary>
    /// <summary>
    /// Deletes a F5 external load balancer appliance added in a zone.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteExternalLoadBalancer(DeleteExternalLoadBalancerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteExternalLoadBalancer(DeleteExternalLoadBalancerRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
