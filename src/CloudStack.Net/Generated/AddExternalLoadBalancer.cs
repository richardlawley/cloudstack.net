using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddExternalLoadBalancerRequest : APIRequest
    {
        public AddExternalLoadBalancerRequest() : base("addExternalLoadBalancer") {}

        /// <summary>
        /// Password of the external load balancer appliance.
        /// </summary>
        public string Password {
            get { return GetParameterValue<string>(nameof(Password).ToLower()); }
            set { SetParameterValue(nameof(Password).ToLower(), value); }
        }

        /// <summary>
        /// URL of the external load balancer appliance.
        /// </summary>
        public string Url {
            get { return GetParameterValue<string>(nameof(Url).ToLower()); }
            set { SetParameterValue(nameof(Url).ToLower(), value); }
        }

        /// <summary>
        /// Username of the external load balancer appliance.
        /// </summary>
        public string Username {
            get { return GetParameterValue<string>(nameof(Username).ToLower()); }
            set { SetParameterValue(nameof(Username).ToLower(), value); }
        }

        /// <summary>
        /// Zone in which to add the external load balancer appliance.
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Adds F5 external load balancer appliance.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ExternalLoadBalancerResponse AddExternalLoadBalancer(AddExternalLoadBalancerRequest request);
        Task<ExternalLoadBalancerResponse> AddExternalLoadBalancerAsync(AddExternalLoadBalancerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ExternalLoadBalancerResponse AddExternalLoadBalancer(AddExternalLoadBalancerRequest request) => _proxy.Request<ExternalLoadBalancerResponse>(request);
        public Task<ExternalLoadBalancerResponse> AddExternalLoadBalancerAsync(AddExternalLoadBalancerRequest request) => _proxy.RequestAsync<ExternalLoadBalancerResponse>(request);
    }
}
