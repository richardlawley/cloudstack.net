using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class PrivateGatewayResponse
    {
        /// <summary>
        /// the id of the private gateway
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the account associated with the private gateway
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// ACL Id set for private gateway
        /// </summary>
        public string AclId { get; set; }

        /// <summary>
        /// the domain associated with the private gateway
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the ID of the domain associated with the private gateway
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// the gateway
        /// </summary>
        public string Gateway { get; set; }

        /// <summary>
        /// the private gateway's ip address
        /// </summary>
        public string Ipaddress { get; set; }

        /// <summary>
        /// the private gateway's netmask
        /// </summary>
        public string Netmask { get; set; }

        /// <summary>
        /// the physical network id
        /// </summary>
        public string PhysicalNetworkId { get; set; }

        /// <summary>
        /// the project name of the private gateway
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// the project id of the private gateway
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// Souce Nat enable status
        /// </summary>
        public bool Sourcenatsupported { get; set; }

        /// <summary>
        /// State of the gateway, can be Creating, Ready, Deleting
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// the network implementation uri for the private gateway
        /// </summary>
        public string Vlan { get; set; }

        /// <summary>
        /// VPC the private gateaway belongs to
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// zone id of the private gateway
        /// </summary>
        public string ZoneId { get; set; }

        /// <summary>
        /// the name of the zone the private gateway belongs to
        /// </summary>
        public string ZoneName { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
