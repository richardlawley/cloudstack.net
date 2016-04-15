using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a F5 external load balancer appliance added in a zone.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteExternalLoadBalancer(DeleteExternalLoadBalancerRequest request);
        Task<SuccessResponse> DeleteExternalLoadBalancerAsync(DeleteExternalLoadBalancerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteExternalLoadBalancer(DeleteExternalLoadBalancerRequest request) => _proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteExternalLoadBalancerAsync(DeleteExternalLoadBalancerRequest request) => _proxy.RequestAsync<SuccessResponse>(request);
    }
}
