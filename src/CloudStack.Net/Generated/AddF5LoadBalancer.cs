using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddF5LoadBalancerRequest : APIRequest
    {
        public AddF5LoadBalancerRequest() : base("addF5LoadBalancer") {}

        /// <summary>
        /// supports only F5BigIpLoadBalancer
        /// </summary>
        public string Networkdevicetype {
            get { return GetParameterValue<string>(nameof(Networkdevicetype).ToLower()); }
            set { SetParameterValue(nameof(Networkdevicetype).ToLower(), value); }
        }

        /// <summary>
        /// Credentials to reach F5 BigIP load balancer device
        /// </summary>
        public string Password {
            get { return GetParameterValue<string>(nameof(Password).ToLower()); }
            set { SetParameterValue(nameof(Password).ToLower(), value); }
        }

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId {
            get { return GetParameterValue<Guid>(nameof(PhysicalNetworkId).ToLower()); }
            set { SetParameterValue(nameof(PhysicalNetworkId).ToLower(), value); }
        }

        /// <summary>
        /// URL of the F5 load balancer appliance.
        /// </summary>
        public string Url {
            get { return GetParameterValue<string>(nameof(Url).ToLower()); }
            set { SetParameterValue(nameof(Url).ToLower(), value); }
        }

        /// <summary>
        /// Credentials to reach F5 BigIP load balancer device
        /// </summary>
        public string Username {
            get { return GetParameterValue<string>(nameof(Username).ToLower()); }
            set { SetParameterValue(nameof(Username).ToLower(), value); }
        }

    }
    /// <summary>
    /// Adds a F5 BigIP load balancer device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AddF5LoadBalancer(AddF5LoadBalancerRequest request);
        Task<AsyncJobResponse> AddF5LoadBalancerAsync(AddF5LoadBalancerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AddF5LoadBalancer(AddF5LoadBalancerRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> AddF5LoadBalancerAsync(AddF5LoadBalancerRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
