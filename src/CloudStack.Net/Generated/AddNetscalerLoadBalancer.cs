using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddNetscalerLoadBalancerRequest : APIRequest
    {
        public AddNetscalerLoadBalancerRequest() : base("addNetscalerLoadBalancer") {}

        /// <summary>
        /// Netscaler device type supports NetscalerMPXLoadBalancer, NetscalerVPXLoadBalancer, NetscalerSDXLoadBalancer
        /// </summary>
        public string Networkdevicetype {
            get { return GetParameterValue<string>(nameof(Networkdevicetype).ToLower()); }
            set { SetParameterValue(nameof(Networkdevicetype).ToLower(), value); }
        }

        /// <summary>
        /// Credentials to reach netscaler load balancer device
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
        /// URL of the netscaler load balancer appliance.
        /// </summary>
        public string Url {
            get { return GetParameterValue<string>(nameof(Url).ToLower()); }
            set { SetParameterValue(nameof(Url).ToLower(), value); }
        }

        /// <summary>
        /// Credentials to reach netscaler load balancer device
        /// </summary>
        public string Username {
            get { return GetParameterValue<string>(nameof(Username).ToLower()); }
            set { SetParameterValue(nameof(Username).ToLower(), value); }
        }

        /// <summary>
        /// true if NetScaler device being added is for providing GSLB service
        /// </summary>
        public bool? Gslbprovider {
            get { return GetParameterValue<bool?>(nameof(Gslbprovider).ToLower()); }
            set { SetParameterValue(nameof(Gslbprovider).ToLower(), value); }
        }

        /// <summary>
        /// public IP of the site
        /// </summary>
        public string Gslbproviderprivateip {
            get { return GetParameterValue<string>(nameof(Gslbproviderprivateip).ToLower()); }
            set { SetParameterValue(nameof(Gslbproviderprivateip).ToLower(), value); }
        }

        /// <summary>
        /// public IP of the site
        /// </summary>
        public string Gslbproviderpublicip {
            get { return GetParameterValue<string>(nameof(Gslbproviderpublicip).ToLower()); }
            set { SetParameterValue(nameof(Gslbproviderpublicip).ToLower(), value); }
        }

        /// <summary>
        /// true if NetScaler device being added is for providing GSLB service exclusively and can not be used for LB
        /// </summary>
        public bool? IsExclusiveGslbProvider {
            get { return GetParameterValue<bool?>(nameof(IsExclusiveGslbProvider).ToLower()); }
            set { SetParameterValue(nameof(IsExclusiveGslbProvider).ToLower(), value); }
        }

    }
    /// <summary>
    /// Adds a netscaler load balancer device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AddNetscalerLoadBalancer(AddNetscalerLoadBalancerRequest request);
        Task<AsyncJobResponse> AddNetscalerLoadBalancerAsync(AddNetscalerLoadBalancerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AddNetscalerLoadBalancer(AddNetscalerLoadBalancerRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> AddNetscalerLoadBalancerAsync(AddNetscalerLoadBalancerRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
