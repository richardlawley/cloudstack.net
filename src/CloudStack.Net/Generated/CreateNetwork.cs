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
        public string DisplayText { get; set; }

        /// <summary>
        /// the name of the network
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the network offering ID
        /// </summary>
        public Guid NetworkOfferingId { get; set; }

        /// <summary>
        /// the zone ID for the network
        /// </summary>
        public Guid ZoneId { get; set; }

        /// <summary>
        /// account that will own the network
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// Network ACL ID associated for the network
        /// </summary>
        public Guid AclId { get; set; }

        /// <summary>
        /// Access control type; supported values are account and domain. In 3.0 all shared networks should have aclType=Domain, and all isolated networks - Account. Account means that only the account owner can use the network, domain - all accounts in the domain can use the network
        /// </summary>
        public string AclType { get; set; }

        /// <summary>
        /// an optional field, whether to the display the network to the end user or not.
        /// </summary>
        public bool? DisplayNetwork { get; set; }

        /// <summary>
        /// domain ID of the account owning a network
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// the ending IP address in the network IP range. If not specified, will be defaulted to startIP
        /// </summary>
        public string EndIp { get; set; }

        /// <summary>
        /// the ending IPv6 address in the IPv6 network range
        /// </summary>
        public string EndIpv6 { get; set; }

        /// <summary>
        /// the gateway of the network. Required for shared networks and isolated networks when it belongs to VPC
        /// </summary>
        public string Gateway { get; set; }

        /// <summary>
        /// the CIDR of IPv6 network, must be at least /64
        /// </summary>
        public string Ip6Cidr { get; set; }

        /// <summary>
        /// the gateway of the IPv6 network. Required for Shared networks
        /// </summary>
        public string Ip6Gateway { get; set; }

        /// <summary>
        /// the isolated private VLAN for this network
        /// </summary>
        public string IsolatedPvlan { get; set; }

        /// <summary>
        /// the netmask of the network. Required for shared networks and isolated networks when it belongs to VPC
        /// </summary>
        public string Netmask { get; set; }

        /// <summary>
        /// network domain
        /// </summary>
        public string NetworkDomain { get; set; }

        /// <summary>
        /// the physical network ID the network belongs to
        /// </summary>
        public Guid PhysicalNetworkId { get; set; }

        /// <summary>
        /// an optional project for the SSH key
        /// </summary>
        public Guid ProjectId { get; set; }

        /// <summary>
        /// the beginning IP address in the network IP range
        /// </summary>
        public string StartIp { get; set; }

        /// <summary>
        /// the beginning IPv6 address in the IPv6 network range
        /// </summary>
        public string StartIpv6 { get; set; }

        /// <summary>
        /// Defines whether to allow subdomains to use networks dedicated to their parent domain(s). Should be used with aclType=Domain, defaulted to allow.subdomain.network.access global config if not specified
        /// </summary>
        public bool? SubdomainAccess { get; set; }

        /// <summary>
        /// the ID or VID of the network
        /// </summary>
        public string Vlan { get; set; }

        /// <summary>
        /// the VPC network belongs to
        /// </summary>
        public Guid VpcId { get; set; }

    }
    /// <summary>
    /// Creates a network
    /// </summary>
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
