using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class PortableIpRangeResponse
    {
        /// <summary>
        /// portable IP range ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the end ip of the portable IP range
        /// </summary>
        public string EndIp { get; set; }

        /// <summary>
        /// the gateway of the VLAN IP range
        /// </summary>
        public string Gateway { get; set; }

        /// <summary>
        /// the netmask of the VLAN IP range
        /// </summary>
        public string Netmask { get; set; }

        /// <summary>
        /// Region Id in which portable ip range is provisioned
        /// </summary>
        public int RegionId { get; set; }

        /// <summary>
        /// the start ip of the portable IP range
        /// </summary>
        public string StartIp { get; set; }

        /// <summary>
        /// the ID or VID of the VLAN.
        /// </summary>
        public string Vlan { get; set; }

        /// <summary>
        /// List of portable IP and association with zone/network/vpc details that are part of GSLB rule
        /// </summary>
        public IList<PortableIpResponse> Portableipaddress { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
