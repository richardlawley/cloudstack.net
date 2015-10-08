using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListNetworksRequest : APIRequest
    {
        public ListNetworksRequest() : base("listNetworks") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// list networks by ACL (access control list) type. Supported values are account and domain
        /// </summary>
        public string AclType { get; set; }

        /// <summary>
        /// list networks available for VM deployment
        /// </summary>
        public bool? CanUseForDeploy { get; set; }

        /// <summary>
        /// list resources by display flag; only ROOT admin is eligible to pass this parameter
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// the network belongs to VPC
        /// </summary>
        public bool? ForVpc { get; set; }

        /// <summary>
        /// list networks by ID
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// defaults to false, but if true, lists all resources from the parent specified by the domainId till leaves.
        /// </summary>
        public bool? Recursive { get; set; }

        /// <summary>
        /// true if network is system, false otherwise
        /// </summary>
        public bool? IsSystem { get; set; }

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
        /// list networks by physical network id
        /// </summary>
        public Guid PhysicalNetworkId { get; set; }

        /// <summary>
        /// list objects by project
        /// </summary>
        public Guid ProjectId { get; set; }

        /// <summary>
        /// list networks by restartRequired
        /// </summary>
        public bool? RestartRequired { get; set; }

        /// <summary>
        /// true if need to list only networks which support specifying IP ranges
        /// </summary>
        public bool? SpecifyIpRanges { get; set; }

        /// <summary>
        /// list networks supporting certain services
        /// </summary>
        public IList<string> SupportedServices { get; set; }

        /// <summary>
        /// List resources by tags (key/value pairs)
        /// </summary>
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// type of the traffic
        /// </summary>
        public string TrafficType { get; set; }

        /// <summary>
        /// the type of the network. Supported values are: isolated and shared
        /// </summary>
        public string GuestIpType { get; set; }

        /// <summary>
        /// List networks by VPC
        /// </summary>
        public Guid VpcId { get; set; }

        /// <summary>
        /// the zone ID of the network
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// Lists all available networks.
    /// </summary>
    /// <summary>
    /// Lists all available networks.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<NetworkResponse> ListNetworks(ListNetworksRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<NetworkResponse> ListNetworks(ListNetworksRequest request) => _proxy.Request<ListResponse<NetworkResponse>>(request);
    }
}
