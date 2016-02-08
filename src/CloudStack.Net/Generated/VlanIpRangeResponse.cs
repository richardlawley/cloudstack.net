using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class VlanIpRangeResponse
    {
        /// <summary>
        /// the ID of the VLAN IP range
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the account of the VLAN IP range
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// the description of the VLAN IP range
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// the domain name of the VLAN IP range
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the domain ID of the VLAN IP range
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// the end ip of the VLAN IP range
        /// </summary>
        public string EndIp { get; set; }

        /// <summary>
        /// the end ipv6 of the VLAN IP range
        /// </summary>
        public string EndIpv6 { get; set; }

        /// <summary>
        /// the virtual network for the VLAN IP range
        /// </summary>
        public bool ForVirtualNetwork { get; set; }

        /// <summary>
        /// the gateway of the VLAN IP range
        /// </summary>
        public string Gateway { get; set; }

        /// <summary>
        /// the cidr of IPv6 network
        /// </summary>
        public string Ip6Cidr { get; set; }

        /// <summary>
        /// the gateway of IPv6 network
        /// </summary>
        public string Ip6Gateway { get; set; }

        /// <summary>
        /// the netmask of the VLAN IP range
        /// </summary>
        public string Netmask { get; set; }

        /// <summary>
        /// the network id of vlan range
        /// </summary>
        public string NetworkId { get; set; }

        /// <summary>
        /// the physical network this belongs to
        /// </summary>
        public string PhysicalNetworkId { get; set; }

        /// <summary>
        /// the Pod ID for the VLAN IP range
        /// </summary>
        public string PodId { get; set; }

        /// <summary>
        /// the Pod name for the VLAN IP range
        /// </summary>
        public string PodName { get; set; }

        /// <summary>
        /// the project name of the vlan range
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// the project id of the vlan range
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// the start ip of the VLAN IP range
        /// </summary>
        public string StartIp { get; set; }

        /// <summary>
        /// the start ipv6 of the VLAN IP range
        /// </summary>
        public string StartIpv6 { get; set; }

        /// <summary>
        /// the ID or VID of the VLAN.
        /// </summary>
        public string Vlan { get; set; }

        /// <summary>
        /// the Zone ID of the VLAN IP range
        /// </summary>
        public string ZoneId { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
