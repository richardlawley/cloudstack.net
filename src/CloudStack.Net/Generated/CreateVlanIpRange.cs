using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateVlanIpRangeRequest : APIRequest
    {
        public CreateVlanIpRangeRequest() : base("createVlanIpRange") {}

        /// <summary>
        /// account who will own the VLAN. If VLAN is Zone wide, this parameter should be ommited
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// domain ID of the account owning a VLAN
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// the ending IP address in the VLAN IP range
        /// </summary>
        public string EndIp { get; set; }

        /// <summary>
        /// the ending IPv6 address in the IPv6 network range
        /// </summary>
        public string EndIpv6 { get; set; }

        /// <summary>
        /// true if VLAN is of Virtual type, false if Direct
        /// </summary>
        public bool? ForVirtualNetwork { get; set; }

        /// <summary>
        /// the gateway of the VLAN IP range
        /// </summary>
        public string Gateway { get; set; }

        /// <summary>
        /// the CIDR of IPv6 network, must be at least /64
        /// </summary>
        public string Ip6Cidr { get; set; }

        /// <summary>
        /// the gateway of the IPv6 network. Required for Shared networks and Isolated networks when it belongs to VPC
        /// </summary>
        public string Ip6Gateway { get; set; }

        /// <summary>
        /// the netmask of the VLAN IP range
        /// </summary>
        public string Netmask { get; set; }

        /// <summary>
        /// the network id
        /// </summary>
        public Guid NetworkID { get; set; }

        /// <summary>
        /// the physical network id
        /// </summary>
        public Guid PhysicalNetworkId { get; set; }

        /// <summary>
        /// optional parameter. Have to be specified for Direct Untagged vlan only.
        /// </summary>
        public Guid PodId { get; set; }

        /// <summary>
        /// project who will own the VLAN. If VLAN is Zone wide, this parameter should be ommited
        /// </summary>
        public Guid ProjectId { get; set; }

        /// <summary>
        /// the beginning IP address in the VLAN IP range
        /// </summary>
        public string StartIp { get; set; }

        /// <summary>
        /// the beginning IPv6 address in the IPv6 network range
        /// </summary>
        public string StartIpv6 { get; set; }

        /// <summary>
        /// the ID or VID of the VLAN. If not specified, will be defaulted to the vlan of the network or if vlan of the network is null - to Untagged
        /// </summary>
        public string Vlan { get; set; }

        /// <summary>
        /// the Zone ID of the VLAN IP range
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// Creates a VLAN IP range.
    /// </summary>
    /// <summary>
    /// Creates a VLAN IP range.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        VlanIpRangeResponse CreateVlanIpRange(CreateVlanIpRangeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public VlanIpRangeResponse CreateVlanIpRange(CreateVlanIpRangeRequest request) => _proxy.Request<VlanIpRangeResponse>(request);
    }
}
