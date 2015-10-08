using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class F5LoadBalancerResponse
    {
        /// <summary>
        /// the management IP address of the external load balancer
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// device capacity
        /// </summary>
        public long Lbdevicecapacity { get; set; }

        /// <summary>
        /// true if device is dedicated for an account
        /// </summary>
        public bool Lbdevicededicated { get; set; }

        /// <summary>
        /// device id of the F5 load balancer
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
        /// the physical network to which this F5 device belongs to
        /// </summary>
        public string PhysicalNetworkId { get; set; }

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
