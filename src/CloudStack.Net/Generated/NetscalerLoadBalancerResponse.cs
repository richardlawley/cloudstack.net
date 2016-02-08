using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class NetscalerLoadBalancerResponse
    {
        /// <summary>
        /// true if NetScaler device is provisioned to be a GSLB service provider
        /// </summary>
        public bool Gslbprovider { get; set; }

        /// <summary>
        /// private IP of the NetScaler representing GSLB site
        /// </summary>
        public string Gslbproviderprivateip { get; set; }

        /// <summary>
        /// public IP of the NetScaler representing GSLB site
        /// </summary>
        public string Gslbproviderpublicip { get; set; }

        /// <summary>
        /// the management IP address of the external load balancer
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// true if NetScaler device is provisioned exclusively to be a GSLB service provider
        /// </summary>
        public bool IsExclusiveGslbProvider { get; set; }

        /// <summary>
        /// device capacity
        /// </summary>
        public long Lbdevicecapacity { get; set; }

        /// <summary>
        /// true if device is dedicated for an account
        /// </summary>
        public bool Lbdevicededicated { get; set; }

        /// <summary>
        /// device id of the netscaler load balancer
        /// </summary>
        public string Lbdeviceid { get; set; }

        /// <summary>
        /// device name
        /// </summary>
        public string Lbdevicename { get; set; }

        /// <summary>
        /// device state
        /// </summary>
        public string Lbdevicestate { get; set; }

        /// <summary>
        /// the physical network to which this netscaler device belongs to
        /// </summary>
        public string PhysicalNetworkId { get; set; }

        /// <summary>
        /// Used when NetScaler device is provider of EIP service. This parameter represents the list of pod's, for which there exists a policy based route on datacenter L3 router to route pod's subnet IP to a NetScaler device.
        /// </summary>
        public IList<long> PodIds { get; set; }

        /// <summary>
        /// the private interface of the load balancer
        /// </summary>
        public string PrivateInterface { get; set; }

        /// <summary>
        /// name of the provider
        /// </summary>
        public string Provider { get; set; }

        /// <summary>
        /// the public interface of the load balancer
        /// </summary>
        public string PublicInterface { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
