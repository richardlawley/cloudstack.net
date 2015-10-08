using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListPublicIpAddressesRequest : APIRequest
    {
        public ListPublicIpAddressesRequest() : base("listPublicIpAddresses") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// limits search results to allocated public IP addresses
        /// </summary>
        public bool? AllocatedOnly { get; set; }

        /// <summary>
        /// lists all public IP addresses associated to the network specified
        /// </summary>
        public Guid AssociatedNetworkId { get; set; }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// list resources by display flag; only ROOT admin is eligible to pass this parameter
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// list only IPs used for load balancing
        /// </summary>
        public bool? ForLoadBalancing { get; set; }

        /// <summary>
        /// the virtual network for the IP address
        /// </summary>
        public bool? ForVirtualNetwork { get; set; }

        /// <summary>
        /// lists IP address by ID
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// lists the specified IP address
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// defaults to false, but if true, lists all resources from the parent specified by the domainId till leaves.
        /// </summary>
        public bool? Recursive { get; set; }

        /// <summary>
        /// list only source NAT IP addresses
        /// </summary>
        public bool? IsSourceNat { get; set; }

        /// <summary>
        /// list only static NAT IP addresses
        /// </summary>
        public bool? IsStaticNat { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// If set to false, list only resources belonging to the command's caller; if set to true - list resources that the caller is authorized to see. Default value is false
        /// </summary>
        public bool? ListAll { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// lists all public IP addresses by physical network ID
        /// </summary>
        public Guid PhysicalNetworkId { get; set; }

        /// <summary>
        /// list objects by project
        /// </summary>
        public Guid ProjectId { get; set; }

        /// <summary>
        /// lists all public IP addresses by state
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// List resources by tags (key/value pairs)
        /// </summary>
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// lists all public IP addresses by VLAN ID
        /// </summary>
        public Guid VlanId { get; set; }

        /// <summary>
        /// List IPs belonging to the VPC
        /// </summary>
        public Guid VpcId { get; set; }

        /// <summary>
        /// lists all public IP addresses by zone ID
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// Lists all public ip addresses
    /// </summary>
    /// <summary>
    /// Lists all public ip addresses
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<IPAddressResponse> ListPublicIpAddresses(ListPublicIpAddressesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<IPAddressResponse> ListPublicIpAddresses(ListPublicIpAddressesRequest request) => _proxy.Request<ListResponse<IPAddressResponse>>(request);
    }
}
