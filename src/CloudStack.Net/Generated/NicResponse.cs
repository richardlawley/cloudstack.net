using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class NicResponse
    {
        /// <summary>
        /// the ID of the nic
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the broadcast uri of the nic
        /// </summary>
        public string BroadcastUri { get; set; }

        /// <summary>
        /// device id for the network when plugged into the virtual machine
        /// </summary>
        public string DeviceId { get; set; }

        /// <summary>
        /// the gateway of the nic
        /// </summary>
        public string Gateway { get; set; }

        /// <summary>
        /// the IPv6 address of network
        /// </summary>
        public string Ip6Address { get; set; }

        /// <summary>
        /// the cidr of IPv6 network
        /// </summary>
        public string Ip6Cidr { get; set; }

        /// <summary>
        /// the gateway of IPv6 network
        /// </summary>
        public string Ip6Gateway { get; set; }

        /// <summary>
        /// the ip address of the nic
        /// </summary>
        public string Ipaddress { get; set; }

        /// <summary>
        /// true if nic is default, false otherwise
        /// </summary>
        public bool IsDefault { get; set; }

        /// <summary>
        /// the isolation uri of the nic
        /// </summary>
        public string IsolationUri { get; set; }

        /// <summary>
        /// true if nic is default, false otherwise
        /// </summary>
        public string MacAddress { get; set; }

        /// <summary>
        /// the netmask of the nic
        /// </summary>
        public string Netmask { get; set; }

        /// <summary>
        /// the ID of the corresponding network
        /// </summary>
        public string NetworkId { get; set; }

        /// <summary>
        /// the name of the corresponding network
        /// </summary>
        public string NetworkName { get; set; }

        /// <summary>
        /// the Secondary ipv4 addr of nic
        /// </summary>
        public IList<NicSecondaryIpResponse> Secondaryip { get; set; }

        /// <summary>
        /// the traffic type of the nic
        /// </summary>
        public string TrafficType { get; set; }

        /// <summary>
        /// the type of the nic
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Id of the vm to which the nic belongs
        /// </summary>
        public string Virtualmachineid { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
