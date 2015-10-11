using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateNetworkRequest : APIRequest
    {
        public CreateNetworkRequest() : base("createNetwork") {}

        /// <summary>
        /// the display text of the network
        /// </summary>
        public string DisplayText {
            get { return (string) Parameters[nameof(DisplayText).ToLower()]; }
            set { Parameters[nameof(DisplayText).ToLower()] = value; }
        }

        /// <summary>
        /// the name of the network
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// the network offering id
        /// </summary>
        public Guid NetworkOfferingId {
            get { return (Guid) Parameters[nameof(NetworkOfferingId).ToLower()]; }
            set { Parameters[nameof(NetworkOfferingId).ToLower()] = value; }
        }

        /// <summary>
        /// the Zone ID for the network
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

        /// <summary>
        /// account who will own the network
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// Network ACL Id associated for the network
        /// </summary>
        public Guid AclId {
            get { return (Guid) Parameters[nameof(AclId).ToLower()]; }
            set { Parameters[nameof(AclId).ToLower()] = value; }
        }

        /// <summary>
        /// Access control type; supported values are account and domain. In 3.0 all shared networks should have aclType=Domain, and all Isolated networks - Account. Account means that only the account owner can use the network, domain - all accouns in the domain can use the network
        /// </summary>
        public string AclType {
            get { return (string) Parameters[nameof(AclType).ToLower()]; }
            set { Parameters[nameof(AclType).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, whether to the display the network to the end user or not.
        /// </summary>
        public bool? DisplayNetwork {
            get { return (bool?) Parameters[nameof(DisplayNetwork).ToLower()]; }
            set { Parameters[nameof(DisplayNetwork).ToLower()] = value; }
        }

        /// <summary>
        /// domain ID of the account owning a network
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// the ending IP address in the network IP range. If not specified, will be defaulted to startIP
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
        /// the gateway of the network. Required for Shared networks and Isolated networks when it belongs to VPC
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
        /// the gateway of the IPv6 network. Required for Shared networks
        /// </summary>
        public string Ip6Gateway {
            get { return (string) Parameters[nameof(Ip6Gateway).ToLower()]; }
            set { Parameters[nameof(Ip6Gateway).ToLower()] = value; }
        }

        /// <summary>
        /// the isolated private vlan for this network
        /// </summary>
        public string IsolatedPvlan {
            get { return (string) Parameters[nameof(IsolatedPvlan).ToLower()]; }
            set { Parameters[nameof(IsolatedPvlan).ToLower()] = value; }
        }

        /// <summary>
        /// the netmask of the network. Required for Shared networks and Isolated networks when it belongs to VPC
        /// </summary>
        public string Netmask {
            get { return (string) Parameters[nameof(Netmask).ToLower()]; }
            set { Parameters[nameof(Netmask).ToLower()] = value; }
        }

        /// <summary>
        /// network domain
        /// </summary>
        public string NetworkDomain {
            get { return (string) Parameters[nameof(NetworkDomain).ToLower()]; }
            set { Parameters[nameof(NetworkDomain).ToLower()] = value; }
        }

        /// <summary>
        /// the Physical Network ID the network belongs to
        /// </summary>
        public Guid PhysicalNetworkId {
            get { return (Guid) Parameters[nameof(PhysicalNetworkId).ToLower()]; }
            set { Parameters[nameof(PhysicalNetworkId).ToLower()] = value; }
        }

        /// <summary>
        /// an optional project for the ssh key
        /// </summary>
        public Guid ProjectId {
            get { return (Guid) Parameters[nameof(ProjectId).ToLower()]; }
            set { Parameters[nameof(ProjectId).ToLower()] = value; }
        }

        /// <summary>
        /// the beginning IP address in the network IP range
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
        /// Defines whether to allow subdomains to use networks dedicated to their parent domain(s). Should be used with aclType=Domain, defaulted to allow.subdomain.network.access global config if not specified
        /// </summary>
        public bool? SubdomainAccess {
            get { return (bool?) Parameters[nameof(SubdomainAccess).ToLower()]; }
            set { Parameters[nameof(SubdomainAccess).ToLower()] = value; }
        }

        /// <summary>
        /// the ID or VID of the network
        /// </summary>
        public string Vlan {
            get { return (string) Parameters[nameof(Vlan).ToLower()]; }
            set { Parameters[nameof(Vlan).ToLower()] = value; }
        }

        /// <summary>
        /// the VPC network belongs to
        /// </summary>
        public Guid VpcId {
            get { return (Guid) Parameters[nameof(VpcId).ToLower()]; }
            set { Parameters[nameof(VpcId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Creates a network
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        NetworkResponse CreateNetwork(CreateNetworkRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public NetworkResponse CreateNetwork(CreateNetworkRequest request) => _proxy.Request<NetworkResponse>(request);
    }
}
