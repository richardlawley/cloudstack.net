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
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// list networks by ACL (access control list) type. Supported values are Account and Domain
        /// </summary>
        public string AclType {
            get { return (string) Parameters[nameof(AclType).ToLower()]; }
            set { Parameters[nameof(AclType).ToLower()] = value; }
        }

        /// <summary>
        /// list networks available for vm deployment
        /// </summary>
        public bool? CanUseForDeploy {
            get { return (bool?) Parameters[nameof(CanUseForDeploy).ToLower()]; }
            set { Parameters[nameof(CanUseForDeploy).ToLower()] = value; }
        }

        /// <summary>
        /// list resources by display flag; only ROOT admin is eligible to pass this parameter
        /// </summary>
        public bool? Displaynetwork {
            get { return (bool?) Parameters[nameof(Displaynetwork).ToLower()]; }
            set { Parameters[nameof(Displaynetwork).ToLower()] = value; }
        }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// the network belongs to vpc
        /// </summary>
        public bool? ForVpc {
            get { return (bool?) Parameters[nameof(ForVpc).ToLower()]; }
            set { Parameters[nameof(ForVpc).ToLower()] = value; }
        }

        /// <summary>
        /// list networks by id
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// defaults to false, but if true, lists all resources from the parent specified by the domainId till leaves.
        /// </summary>
        public bool? Isrecursive {
            get { return (bool?) Parameters[nameof(Isrecursive).ToLower()]; }
            set { Parameters[nameof(Isrecursive).ToLower()] = value; }
        }

        /// <summary>
        /// true if network is system, false otherwise
        /// </summary>
        public bool? IsSystem {
            get { return (bool?) Parameters[nameof(IsSystem).ToLower()]; }
            set { Parameters[nameof(IsSystem).ToLower()] = value; }
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

        public int? Page {
            get { return (int?) Parameters[nameof(Page).ToLower()]; }
            set { Parameters[nameof(Page).ToLower()] = value; }
        }

        public int? PageSize {
            get { return (int?) Parameters[nameof(PageSize).ToLower()]; }
            set { Parameters[nameof(PageSize).ToLower()] = value; }
        }

        /// <summary>
        /// list networks by physical network id
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
        /// list networks by restartRequired
        /// </summary>
        public bool? RestartRequired {
            get { return (bool?) Parameters[nameof(RestartRequired).ToLower()]; }
            set { Parameters[nameof(RestartRequired).ToLower()] = value; }
        }

        /// <summary>
        /// true if need to list only networks which support specifying ip ranges
        /// </summary>
        public bool? SpecifyIpRanges {
            get { return (bool?) Parameters[nameof(SpecifyIpRanges).ToLower()]; }
            set { Parameters[nameof(SpecifyIpRanges).ToLower()] = value; }
        }

        /// <summary>
        /// list networks supporting certain services
        /// </summary>
        public IList<string> SupportedServices {
            get { return (IList<string>) Parameters[nameof(SupportedServices).ToLower()]; }
            set { Parameters[nameof(SupportedServices).ToLower()] = value; }
        }

        /// <summary>
        /// List resources by tags (key/value pairs)
        /// </summary>
        public IDictionary<string, string> Tags {
            get { return (IDictionary<string, string>) Parameters[nameof(Tags).ToLower()]; }
            set { Parameters[nameof(Tags).ToLower()] = value; }
        }

        /// <summary>
        /// type of the traffic
        /// </summary>
        public string TrafficType {
            get { return (string) Parameters[nameof(TrafficType).ToLower()]; }
            set { Parameters[nameof(TrafficType).ToLower()] = value; }
        }

        /// <summary>
        /// the type of the network. Supported values are: Isolated and Shared
        /// </summary>
        public string Type {
            get { return (string) Parameters[nameof(Type).ToLower()]; }
            set { Parameters[nameof(Type).ToLower()] = value; }
        }

        /// <summary>
        /// List networks by VPC
        /// </summary>
        public Guid VpcId {
            get { return (Guid) Parameters[nameof(VpcId).ToLower()]; }
            set { Parameters[nameof(VpcId).ToLower()] = value; }
        }

        /// <summary>
        /// the Zone ID of the network
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

    }
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
