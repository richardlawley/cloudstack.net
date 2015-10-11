using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (string) Parameters[nameof(Networkdevicetype).ToLower()]; }
            set { Parameters[nameof(Networkdevicetype).ToLower()] = value; }
        }

        /// <summary>
        /// Credentials to reach netscaler load balancer device
        /// </summary>
        public string Password {
            get { return (string) Parameters[nameof(Password).ToLower()]; }
            set { Parameters[nameof(Password).ToLower()] = value; }
        }

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId {
            get { return (Guid) Parameters[nameof(PhysicalNetworkId).ToLower()]; }
            set { Parameters[nameof(PhysicalNetworkId).ToLower()] = value; }
        }

        /// <summary>
        /// URL of the netscaler load balancer appliance.
        /// </summary>
        public string Url {
            get { return (string) Parameters[nameof(Url).ToLower()]; }
            set { Parameters[nameof(Url).ToLower()] = value; }
        }

        /// <summary>
        /// Credentials to reach netscaler load balancer device
        /// </summary>
        public string Username {
            get { return (string) Parameters[nameof(Username).ToLower()]; }
            set { Parameters[nameof(Username).ToLower()] = value; }
        }

        /// <summary>
        /// true if NetScaler device being added is for providing GSLB service
        /// </summary>
        public bool? Gslbprovider {
            get { return (bool?) Parameters[nameof(Gslbprovider).ToLower()]; }
            set { Parameters[nameof(Gslbprovider).ToLower()] = value; }
        }

        /// <summary>
        /// public IP of the site
        /// </summary>
        public string Gslbproviderprivateip {
            get { return (string) Parameters[nameof(Gslbproviderprivateip).ToLower()]; }
            set { Parameters[nameof(Gslbproviderprivateip).ToLower()] = value; }
        }

        /// <summary>
        /// public IP of the site
        /// </summary>
        public string Gslbproviderpublicip {
            get { return (string) Parameters[nameof(Gslbproviderpublicip).ToLower()]; }
            set { Parameters[nameof(Gslbproviderpublicip).ToLower()] = value; }
        }

        /// <summary>
        /// true if NetScaler device being added is for providing GSLB service exclusively and can not be used for LB
        /// </summary>
        public bool? IsExclusiveGslbProvider {
            get { return (bool?) Parameters[nameof(IsExclusiveGslbProvider).ToLower()]; }
            set { Parameters[nameof(IsExclusiveGslbProvider).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Adds a netscaler load balancer device
    /// </summary>
    /// <summary>
    /// Adds a netscaler load balancer device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        NetscalerLoadBalancerResponse AddNetscalerLoadBalancer(AddNetscalerLoadBalancerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public NetscalerLoadBalancerResponse AddNetscalerLoadBalancer(AddNetscalerLoadBalancerRequest request) => _proxy.Request<NetscalerLoadBalancerResponse>(request);
    }
}
