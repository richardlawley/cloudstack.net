using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// domain ID of the account owning a VLAN
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// the ending IP address in the VLAN IP range
        /// </summary>
        public string EndIp {
            get { return GetParameterValue<string>(nameof(EndIp).ToLower()); }
            set { SetParameterValue(nameof(EndIp).ToLower(), value); }
        }

        /// <summary>
        /// the ending IPv6 address in the IPv6 network range
        /// </summary>
        public string EndIpv6 {
            get { return GetParameterValue<string>(nameof(EndIpv6).ToLower()); }
            set { SetParameterValue(nameof(EndIpv6).ToLower(), value); }
        }

        /// <summary>
        /// true if VLAN is of Virtual type, false if Direct
        /// </summary>
        public bool? ForVirtualNetwork {
            get { return GetParameterValue<bool?>(nameof(ForVirtualNetwork).ToLower()); }
            set { SetParameterValue(nameof(ForVirtualNetwork).ToLower(), value); }
        }

        /// <summary>
        /// the gateway of the VLAN IP range
        /// </summary>
        public string Gateway {
            get { return GetParameterValue<string>(nameof(Gateway).ToLower()); }
            set { SetParameterValue(nameof(Gateway).ToLower(), value); }
        }

        /// <summary>
        /// the CIDR of IPv6 network, must be at least /64
        /// </summary>
        public string Ip6Cidr {
            get { return GetParameterValue<string>(nameof(Ip6Cidr).ToLower()); }
            set { SetParameterValue(nameof(Ip6Cidr).ToLower(), value); }
        }

        /// <summary>
        /// the gateway of the IPv6 network. Required for Shared networks and Isolated networks when it belongs to VPC
        /// </summary>
        public string Ip6Gateway {
            get { return GetParameterValue<string>(nameof(Ip6Gateway).ToLower()); }
            set { SetParameterValue(nameof(Ip6Gateway).ToLower(), value); }
        }

        /// <summary>
        /// the netmask of the VLAN IP range
        /// </summary>
        public string Netmask {
            get { return GetParameterValue<string>(nameof(Netmask).ToLower()); }
            set { SetParameterValue(nameof(Netmask).ToLower(), value); }
        }

        /// <summary>
        /// the network id
        /// </summary>
        public Guid? NetworkID {
            get { return GetParameterValue<Guid?>(nameof(NetworkID).ToLower()); }
            set { SetParameterValue(nameof(NetworkID).ToLower(), value); }
        }

        /// <summary>
        /// the physical network id
        /// </summary>
        public Guid? PhysicalNetworkId {
            get { return GetParameterValue<Guid?>(nameof(PhysicalNetworkId).ToLower()); }
            set { SetParameterValue(nameof(PhysicalNetworkId).ToLower(), value); }
        }

        /// <summary>
        /// optional parameter. Have to be specified for Direct Untagged vlan only.
        /// </summary>
        public Guid? PodId {
            get { return GetParameterValue<Guid?>(nameof(PodId).ToLower()); }
            set { SetParameterValue(nameof(PodId).ToLower(), value); }
        }

        /// <summary>
        /// project who will own the VLAN. If VLAN is Zone wide, this parameter should be ommited
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// the beginning IP address in the VLAN IP range
        /// </summary>
        public string StartIp {
            get { return GetParameterValue<string>(nameof(StartIp).ToLower()); }
            set { SetParameterValue(nameof(StartIp).ToLower(), value); }
        }

        /// <summary>
        /// the beginning IPv6 address in the IPv6 network range
        /// </summary>
        public string StartIpv6 {
            get { return GetParameterValue<string>(nameof(StartIpv6).ToLower()); }
            set { SetParameterValue(nameof(StartIpv6).ToLower(), value); }
        }

        /// <summary>
        /// the ID or VID of the VLAN. If not specified, will be defaulted to the vlan of the network or if vlan of the network is null - to Untagged
        /// </summary>
        public string Vlan {
            get { return GetParameterValue<string>(nameof(Vlan).ToLower()); }
            set { SetParameterValue(nameof(Vlan).ToLower(), value); }
        }

        /// <summary>
        /// the Zone ID of the VLAN IP range
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates a VLAN IP range.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        VlanIpRangeResponse CreateVlanIpRange(CreateVlanIpRangeRequest request);
        Task<VlanIpRangeResponse> CreateVlanIpRangeAsync(CreateVlanIpRangeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public VlanIpRangeResponse CreateVlanIpRange(CreateVlanIpRangeRequest request) => _proxy.Request<VlanIpRangeResponse>(request);
        public Task<VlanIpRangeResponse> CreateVlanIpRangeAsync(CreateVlanIpRangeRequest request) => _proxy.RequestAsync<VlanIpRangeResponse>(request);
    }
}
