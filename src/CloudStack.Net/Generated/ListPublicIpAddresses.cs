using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListPublicIpAddressesRequest : APIListRequest
    {
        public ListPublicIpAddressesRequest() : base("listPublicIpAddresses") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// limits search results to allocated public IP addresses
        /// </summary>
        public bool? AllocatedOnly {
            get { return (bool?) Parameters[nameof(AllocatedOnly).ToLower()]; }
            set { Parameters[nameof(AllocatedOnly).ToLower()] = value; }
        }

        /// <summary>
        /// lists all public IP addresses associated to the network specified
        /// </summary>
        public Guid AssociatedNetworkId {
            get { return (Guid) Parameters[nameof(AssociatedNetworkId).ToLower()]; }
            set { Parameters[nameof(AssociatedNetworkId).ToLower()] = value; }
        }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// list resources by display flag; only ROOT admin is eligible to pass this parameter
        /// </summary>
        public bool? Fordisplay {
            get { return (bool?) Parameters[nameof(Fordisplay).ToLower()]; }
            set { Parameters[nameof(Fordisplay).ToLower()] = value; }
        }

        /// <summary>
        /// list only IPs used for load balancing
        /// </summary>
        public bool? ForLoadBalancing {
            get { return (bool?) Parameters[nameof(ForLoadBalancing).ToLower()]; }
            set { Parameters[nameof(ForLoadBalancing).ToLower()] = value; }
        }

        /// <summary>
        /// the virtual network for the IP address
        /// </summary>
        public bool? ForVirtualNetwork {
            get { return (bool?) Parameters[nameof(ForVirtualNetwork).ToLower()]; }
            set { Parameters[nameof(ForVirtualNetwork).ToLower()] = value; }
        }

        /// <summary>
        /// lists IP address by ID
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// lists the specified IP address
        /// </summary>
        public string IpAddress {
            get { return (string) Parameters[nameof(IpAddress).ToLower()]; }
            set { Parameters[nameof(IpAddress).ToLower()] = value; }
        }

        /// <summary>
        /// defaults to false, but if true, lists all resources from the parent specified by the domainId till leaves.
        /// </summary>
        public bool? Isrecursive {
            get { return (bool?) Parameters[nameof(Isrecursive).ToLower()]; }
            set { Parameters[nameof(Isrecursive).ToLower()] = value; }
        }

        /// <summary>
        /// list only source NAT IP addresses
        /// </summary>
        public bool? IsSourceNat {
            get { return (bool?) Parameters[nameof(IsSourceNat).ToLower()]; }
            set { Parameters[nameof(IsSourceNat).ToLower()] = value; }
        }

        /// <summary>
        /// list only static NAT IP addresses
        /// </summary>
        public bool? IsStaticNat {
            get { return (bool?) Parameters[nameof(IsStaticNat).ToLower()]; }
            set { Parameters[nameof(IsStaticNat).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        /// <summary>
        /// If set to false, list only resources belonging to the command's caller; if set to true - list resources that the caller is authorized to see. Default value is false
        /// </summary>
        public bool? ListAll {
            get { return (bool?) Parameters[nameof(ListAll).ToLower()]; }
            set { Parameters[nameof(ListAll).ToLower()] = value; }
        }

        /// <summary>
        /// lists all public IP addresses by physical network ID
        /// </summary>
        public Guid PhysicalNetworkId {
            get { return (Guid) Parameters[nameof(PhysicalNetworkId).ToLower()]; }
            set { Parameters[nameof(PhysicalNetworkId).ToLower()] = value; }
        }

        /// <summary>
        /// list objects by project
        /// </summary>
        public Guid ProjectId {
            get { return (Guid) Parameters[nameof(ProjectId).ToLower()]; }
            set { Parameters[nameof(ProjectId).ToLower()] = value; }
        }

        /// <summary>
        /// lists all public IP addresses by state
        /// </summary>
        public string State {
            get { return (string) Parameters[nameof(State).ToLower()]; }
            set { Parameters[nameof(State).ToLower()] = value; }
        }

        /// <summary>
        /// List resources by tags (key/value pairs)
        /// </summary>
        public IList<IDictionary<string, object>> Tags {
            get { return GetList<IDictionary<string, object>>(nameof(Tags).ToLower()); }
            set { Parameters[nameof(Tags).ToLower()] = value; }
        }

        /// <summary>
        /// lists all public IP addresses by VLAN ID
        /// </summary>
        public Guid VlanId {
            get { return (Guid) Parameters[nameof(VlanId).ToLower()]; }
            set { Parameters[nameof(VlanId).ToLower()] = value; }
        }

        /// <summary>
        /// List IPs belonging to the VPC
        /// </summary>
        public Guid VpcId {
            get { return (Guid) Parameters[nameof(VpcId).ToLower()]; }
            set { Parameters[nameof(VpcId).ToLower()] = value; }
        }

        /// <summary>
        /// lists all public IP addresses by zone ID
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists all public ip addresses
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<IPAddressResponse> ListPublicIpAddresses(ListPublicIpAddressesRequest request);
        Task<ListResponse<IPAddressResponse>> ListPublicIpAddressesAsync(ListPublicIpAddressesRequest request);
        ListResponse<IPAddressResponse> ListPublicIpAddressesAllPages(ListPublicIpAddressesRequest request);
        Task<ListResponse<IPAddressResponse>> ListPublicIpAddressesAllPagesAsync(ListPublicIpAddressesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<IPAddressResponse> ListPublicIpAddresses(ListPublicIpAddressesRequest request) => _proxy.Request<ListResponse<IPAddressResponse>>(request);
        public Task<ListResponse<IPAddressResponse>> ListPublicIpAddressesAsync(ListPublicIpAddressesRequest request) => _proxy.RequestAsync<ListResponse<IPAddressResponse>>(request);
        public ListResponse<IPAddressResponse> ListPublicIpAddressesAllPages(ListPublicIpAddressesRequest request) => _proxy.RequestAllPages<IPAddressResponse>(request);
        public Task<ListResponse<IPAddressResponse>> ListPublicIpAddressesAllPagesAsync(ListPublicIpAddressesRequest request) => _proxy.RequestAllPagesAsync<IPAddressResponse>(request);
    }
}
