using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class BaremetalDhcpResponse
    {
        /// <summary>
        /// device id of 
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// name of the provider
        /// </summary>
        public string Dhcpservertype { get; set; }

        /// <summary>
        /// the physical network to which this external dhcp device belongs to
        /// </summary>
        public string PhysicalNetworkId { get; set; }

        /// <summary>
        /// name of the provider
        /// </summary>
        public string Provider { get; set; }

        /// <summary>
        /// url
        /// </summary>
        public string Url { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
