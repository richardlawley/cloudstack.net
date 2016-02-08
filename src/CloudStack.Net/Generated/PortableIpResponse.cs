using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class PortableIpResponse
    {
        /// <summary>
        /// the account ID the portable IP address is associated with
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// date the portal IP address was acquired
        /// </summary>
        public DateTime Allocated { get; set; }

        /// <summary>
        /// the domain ID the portable IP address is associated with
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// public IP address
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// the ID of the Network where ip belongs to
        /// </summary>
        public string NetworkId { get; set; }

        /// <summary>
        /// the physical network this belongs to
        /// </summary>
        public string PhysicalNetworkId { get; set; }

        /// <summary>
        /// Region Id in which global load balancer is created
        /// </summary>
        public int RegionId { get; set; }

        /// <summary>
        /// State of the ip address. Can be: Allocatin, Allocated and Releasing
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// VPC the ip belongs to
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// the ID of the zone the public IP address belongs to
        /// </summary>
        public string ZoneId { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
