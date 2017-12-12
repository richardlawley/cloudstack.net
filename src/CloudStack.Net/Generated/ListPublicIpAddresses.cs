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
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// limits search results to allocated public IP addresses
        /// </summary>
        public bool? AllocatedOnly {
            get { return GetParameterValue<bool?>(nameof(AllocatedOnly).ToLower()); }
            set { SetParameterValue(nameof(AllocatedOnly).ToLower(), value); }
        }

        /// <summary>
        /// lists all public IP addresses associated to the network specified
        /// </summary>
        public Guid? AssociatedNetworkId {
            get { return GetParameterValue<Guid?>(nameof(AssociatedNetworkId).ToLower()); }
            set { SetParameterValue(nameof(AssociatedNetworkId).ToLower(), value); }
        }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// list resources by display flag; only ROOT admin is eligible to pass this parameter
        /// </summary>
        public bool? Fordisplay {
            get { return GetParameterValue<bool?>(nameof(Fordisplay).ToLower()); }
            set { SetParameterValue(nameof(Fordisplay).ToLower(), value); }
        }

        /// <summary>
        /// list only IPs used for load balancing
        /// </summary>
        public bool? ForLoadBalancing {
            get { return GetParameterValue<bool?>(nameof(ForLoadBalancing).ToLower()); }
            set { SetParameterValue(nameof(ForLoadBalancing).ToLower(), value); }
        }

        /// <summary>
        /// the virtual network for the IP address
        /// </summary>
        public bool? ForVirtualNetwork {
            get { return GetParameterValue<bool?>(nameof(ForVirtualNetwork).ToLower()); }
            set { SetParameterValue(nameof(ForVirtualNetwork).ToLower(), value); }
        }

        /// <summary>
        /// lists IP address by ID
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// lists the specified IP address
        /// </summary>
        public string IpAddress {
            get { return GetParameterValue<string>(nameof(IpAddress).ToLower()); }
            set { SetParameterValue(nameof(IpAddress).ToLower(), value); }
        }

        /// <summary>
        /// defaults to false, but if true, lists all resources from the parent specified by the domainId till leaves.
        /// </summary>
        public bool? Isrecursive {
            get { return GetParameterValue<bool?>(nameof(Isrecursive).ToLower()); }
            set { SetParameterValue(nameof(Isrecursive).ToLower(), value); }
        }

        /// <summary>
        /// list only source NAT IP addresses
        /// </summary>
        public bool? IsSourceNat {
            get { return GetParameterValue<bool?>(nameof(IsSourceNat).ToLower()); }
            set { SetParameterValue(nameof(IsSourceNat).ToLower(), value); }
        }

        /// <summary>
        /// list only static NAT IP addresses
        /// </summary>
        public bool? IsStaticNat {
            get { return GetParameterValue<bool?>(nameof(IsStaticNat).ToLower()); }
            set { SetParameterValue(nameof(IsStaticNat).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// If set to false, list only resources belonging to the command's caller; if set to true - list resources that the caller is authorized to see. Default value is false
        /// </summary>
        public bool? ListAll {
            get { return GetParameterValue<bool?>(nameof(ListAll).ToLower()); }
            set { SetParameterValue(nameof(ListAll).ToLower(), value); }
        }

        /// <summary>
        /// lists all public IP addresses by physical network ID
        /// </summary>
        public Guid? PhysicalNetworkId {
            get { return GetParameterValue<Guid?>(nameof(PhysicalNetworkId).ToLower()); }
            set { SetParameterValue(nameof(PhysicalNetworkId).ToLower(), value); }
        }

        /// <summary>
        /// list objects by project
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// lists all public IP addresses by state
        /// </summary>
        public string State {
            get { return GetParameterValue<string>(nameof(State).ToLower()); }
            set { SetParameterValue(nameof(State).ToLower(), value); }
        }

        /// <summary>
        /// List resources by tags (key/value pairs)
        /// </summary>
        public IList<IDictionary<string, object>> Tags {
            get { return GetList<IDictionary<string, object>>(nameof(Tags).ToLower()); }
            set { SetParameterValue(nameof(Tags).ToLower(), value); }
        }

        /// <summary>
        /// lists all public IP addresses by VLAN ID
        /// </summary>
        public Guid? VlanId {
            get { return GetParameterValue<Guid?>(nameof(VlanId).ToLower()); }
            set { SetParameterValue(nameof(VlanId).ToLower(), value); }
        }

        /// <summary>
        /// List IPs belonging to the VPC
        /// </summary>
        public Guid? VpcId {
            get { return GetParameterValue<Guid?>(nameof(VpcId).ToLower()); }
            set { SetParameterValue(nameof(VpcId).ToLower(), value); }
        }

        /// <summary>
        /// lists all public IP addresses by zone ID
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
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
        public ListResponse<IPAddressResponse> ListPublicIpAddresses(ListPublicIpAddressesRequest request) => Proxy.Request<ListResponse<IPAddressResponse>>(request);
        public Task<ListResponse<IPAddressResponse>> ListPublicIpAddressesAsync(ListPublicIpAddressesRequest request) => Proxy.RequestAsync<ListResponse<IPAddressResponse>>(request);
        public ListResponse<IPAddressResponse> ListPublicIpAddressesAllPages(ListPublicIpAddressesRequest request) => Proxy.RequestAllPages<IPAddressResponse>(request);
        public Task<ListResponse<IPAddressResponse>> ListPublicIpAddressesAllPagesAsync(ListPublicIpAddressesRequest request) => Proxy.RequestAllPagesAsync<IPAddressResponse>(request);
    }
}
