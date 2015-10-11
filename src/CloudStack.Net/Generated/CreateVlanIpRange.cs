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
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// domain ID of the account owning a VLAN
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// the ending IP address in the VLAN IP range
        /// </summary>
        public string EndIp {
            get { return (string) Parameters[nameof(EndIp).ToLower()]; }
            set { Parameters[nameof(EndIp).ToLower()] = value; }
        }

        /// <summary>
        /// the ending IPv6 address in the IPv6 network range
        /// </summary>
        public string EndIpv6 {
            get { return (string) Parameters[nameof(EndIpv6).ToLower()]; }
            set { Parameters[nameof(EndIpv6).ToLower()] = value; }
        }

        /// <summary>
        /// true if VLAN is of Virtual type, false if Direct
        /// </summary>
        public bool? ForVirtualNetwork {
            get { return (bool?) Parameters[nameof(ForVirtualNetwork).ToLower()]; }
            set { Parameters[nameof(ForVirtualNetwork).ToLower()] = value; }
        }

        /// <summary>
        /// the gateway of the VLAN IP range
        /// </summary>
        public string Gateway {
            get { return (string) Parameters[nameof(Gateway).ToLower()]; }
            set { Parameters[nameof(Gateway).ToLower()] = value; }
        }

        /// <summary>
        /// the CIDR of IPv6 network, must be at least /64
        /// </summary>
        public string Ip6Cidr {
            get { return (string) Parameters[nameof(Ip6Cidr).ToLower()]; }
            set { Parameters[nameof(Ip6Cidr).ToLower()] = value; }
        }

        /// <summary>
        /// the gateway of the IPv6 network. Required for Shared networks and Isolated networks when it belongs to VPC
        /// </summary>
        public string Ip6Gateway {
            get { return (string) Parameters[nameof(Ip6Gateway).ToLower()]; }
            set { Parameters[nameof(Ip6Gateway).ToLower()] = value; }
        }

        /// <summary>
        /// the netmask of the VLAN IP range
        /// </summary>
        public string Netmask {
            get { return (string) Parameters[nameof(Netmask).ToLower()]; }
            set { Parameters[nameof(Netmask).ToLower()] = value; }
        }

        /// <summary>
        /// the network id
        /// </summary>
        public Guid NetworkID {
            get { return (Guid) Parameters[nameof(NetworkID).ToLower()]; }
            set { Parameters[nameof(NetworkID).ToLower()] = value; }
        }

        /// <summary>
        /// the physical network id
        /// </summary>
        public Guid PhysicalNetworkId {
            get { return (Guid) Parameters[nameof(PhysicalNetworkId).ToLower()]; }
            set { Parameters[nameof(PhysicalNetworkId).ToLower()] = value; }
        }

        /// <summary>
        /// optional parameter. Have to be specified for Direct Untagged vlan only.
        /// </summary>
        public Guid PodId {
            get { return (Guid) Parameters[nameof(PodId).ToLower()]; }
            set { Parameters[nameof(PodId).ToLower()] = value; }
        }

        /// <summary>
        /// project who will own the VLAN. If VLAN is Zone wide, this parameter should be ommited
        /// </summary>
        public Guid ProjectId {
            get { return (Guid) Parameters[nameof(ProjectId).ToLower()]; }
            set { Parameters[nameof(ProjectId).ToLower()] = value; }
        }

        /// <summary>
        /// the beginning IP address in the VLAN IP range
        /// </summary>
        public string StartIp {
            get { return (string) Parameters[nameof(StartIp).ToLower()]; }
            set { Parameters[nameof(StartIp).ToLower()] = value; }
        }

        /// <summary>
        /// the beginning IPv6 address in the IPv6 network range
        /// </summary>
        public string StartIpv6 {
            get { return (string) Parameters[nameof(StartIpv6).ToLower()]; }
            set { Parameters[nameof(StartIpv6).ToLower()] = value; }
        }

        /// <summary>
        /// the ID or VID of the VLAN. If not specified, will be defaulted to the vlan of the network or if vlan of the network is null - to Untagged
        /// </summary>
        public string Vlan {
            get { return (string) Parameters[nameof(Vlan).ToLower()]; }
            set { Parameters[nameof(Vlan).ToLower()] = value; }
        }

        /// <summary>
        /// the Zone ID of the VLAN IP range
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

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
