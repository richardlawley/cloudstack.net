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
        public string DeviceType { get; set; }

        /// <summary>
        /// Credentials to reach netscaler load balancer device
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId { get; set; }

        /// <summary>
        /// URL of the netscaler load balancer appliance.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Credentials to reach netscaler load balancer device
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// true if NetScaler device being added is for providing GSLB service
        /// </summary>
        public bool? IsGslbProvider { get; set; }

        /// <summary>
        /// public IP of the site
        /// </summary>
        public string GslbSitePrivateIp { get; set; }

        /// <summary>
        /// public IP of the site
        /// </summary>
        public string GslbSitePublicIp { get; set; }

        /// <summary>
        /// true if NetScaler device being added is for providing GSLB service exclusively and can not be used for LB
        /// </summary>
        public bool? IsExclusiveGslbProvider { get; set; }

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
