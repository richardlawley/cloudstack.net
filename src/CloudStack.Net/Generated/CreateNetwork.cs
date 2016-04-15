using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<string>(nameof(DisplayText).ToLower()); }
            set { SetParameterValue(nameof(DisplayText).ToLower(), value); }
        }

        /// <summary>
        /// the name of the network
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// the network offering ID
        /// </summary>
        public Guid NetworkOfferingId {
            get { return GetParameterValue<Guid>(nameof(NetworkOfferingId).ToLower()); }
            set { SetParameterValue(nameof(NetworkOfferingId).ToLower(), value); }
        }

        /// <summary>
        /// the zone ID for the network
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

        /// <summary>
        /// account that will own the network
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// Network ACL ID associated for the network
        /// </summary>
        public Guid AclId {
            get { return GetParameterValue<Guid>(nameof(AclId).ToLower()); }
            set { SetParameterValue(nameof(AclId).ToLower(), value); }
        }

        /// <summary>
        /// Access control type; supported values are account and domain. In 3.0 all shared networks should have aclType=Domain, and all isolated networks - Account. Account means that only the account owner can use the network, domain - all accounts in the domain can use the network
        /// </summary>
        public string AclType {
            get { return GetParameterValue<string>(nameof(AclType).ToLower()); }
            set { SetParameterValue(nameof(AclType).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, whether to the display the network to the end user or not.
        /// </summary>
        public bool? DisplayNetwork {
            get { return GetParameterValue<bool?>(nameof(DisplayNetwork).ToLower()); }
            set { SetParameterValue(nameof(DisplayNetwork).ToLower(), value); }
        }

        /// <summary>
        /// domain ID of the account owning a network
        /// </summary>
        public Guid DomainId {
            get { return GetParameterValue<Guid>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// the ending IP address in the network IP range. If not specified, will be defaulted to startIP
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
        /// the gateway of the network. Required for shared networks and isolated networks when it belongs to VPC
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
        /// the gateway of the IPv6 network. Required for Shared networks
        /// </summary>
        public string Ip6Gateway {
            get { return GetParameterValue<string>(nameof(Ip6Gateway).ToLower()); }
            set { SetParameterValue(nameof(Ip6Gateway).ToLower(), value); }
        }

        /// <summary>
        /// the isolated private VLAN for this network
        /// </summary>
        public string IsolatedPvlan {
            get { return GetParameterValue<string>(nameof(IsolatedPvlan).ToLower()); }
            set { SetParameterValue(nameof(IsolatedPvlan).ToLower(), value); }
        }

        /// <summary>
        /// the netmask of the network. Required for shared networks and isolated networks when it belongs to VPC
        /// </summary>
        public string Netmask {
            get { return GetParameterValue<string>(nameof(Netmask).ToLower()); }
            set { SetParameterValue(nameof(Netmask).ToLower(), value); }
        }

        /// <summary>
        /// network domain
        /// </summary>
        public string NetworkDomain {
            get { return GetParameterValue<string>(nameof(NetworkDomain).ToLower()); }
            set { SetParameterValue(nameof(NetworkDomain).ToLower(), value); }
        }

        /// <summary>
        /// the physical network ID the network belongs to
        /// </summary>
        public Guid PhysicalNetworkId {
            get { return GetParameterValue<Guid>(nameof(PhysicalNetworkId).ToLower()); }
            set { SetParameterValue(nameof(PhysicalNetworkId).ToLower(), value); }
        }

        /// <summary>
        /// an optional project for the SSH key
        /// </summary>
        public Guid ProjectId {
            get { return GetParameterValue<Guid>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// the beginning IP address in the network IP range
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
        /// Defines whether to allow subdomains to use networks dedicated to their parent domain(s). Should be used with aclType=Domain, defaulted to allow.subdomain.network.access global config if not specified
        /// </summary>
        public bool? SubdomainAccess {
            get { return GetParameterValue<bool?>(nameof(SubdomainAccess).ToLower()); }
            set { SetParameterValue(nameof(SubdomainAccess).ToLower(), value); }
        }

        /// <summary>
        /// the ID or VID of the network
        /// </summary>
        public string Vlan {
            get { return GetParameterValue<string>(nameof(Vlan).ToLower()); }
            set { SetParameterValue(nameof(Vlan).ToLower(), value); }
        }

        /// <summary>
        /// the VPC network belongs to
        /// </summary>
        public Guid VpcId {
            get { return GetParameterValue<Guid>(nameof(VpcId).ToLower()); }
            set { SetParameterValue(nameof(VpcId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates a network
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        NetworkResponse CreateNetwork(CreateNetworkRequest request);
        Task<NetworkResponse> CreateNetworkAsync(CreateNetworkRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public NetworkResponse CreateNetwork(CreateNetworkRequest request) => _proxy.Request<NetworkResponse>(request);
        public Task<NetworkResponse> CreateNetworkAsync(CreateNetworkRequest request) => _proxy.RequestAsync<NetworkResponse>(request);
    }
}
