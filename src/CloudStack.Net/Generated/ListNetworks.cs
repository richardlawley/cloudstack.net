using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListNetworksRequest : APIListRequest
    {
        public ListNetworksRequest() : base("listNetworks") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// list networks by ACL (access control list) type. Supported values are account and domain
        /// </summary>
        public string AclType {
            get { return GetParameterValue<string>(nameof(AclType).ToLower()); }
            set { SetParameterValue(nameof(AclType).ToLower(), value); }
        }

        /// <summary>
        /// list networks available for VM deployment
        /// </summary>
        public bool? CanUseForDeploy {
            get { return GetParameterValue<bool?>(nameof(CanUseForDeploy).ToLower()); }
            set { SetParameterValue(nameof(CanUseForDeploy).ToLower(), value); }
        }

        /// <summary>
        /// list resources by display flag; only ROOT admin is eligible to pass this parameter
        /// </summary>
        public bool? Displaynetwork {
            get { return GetParameterValue<bool?>(nameof(Displaynetwork).ToLower()); }
            set { SetParameterValue(nameof(Displaynetwork).ToLower(), value); }
        }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// the network belongs to VPC
        /// </summary>
        public bool? ForVpc {
            get { return GetParameterValue<bool?>(nameof(ForVpc).ToLower()); }
            set { SetParameterValue(nameof(ForVpc).ToLower(), value); }
        }

        /// <summary>
        /// list networks by ID
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// defaults to false, but if true, lists all resources from the parent specified by the domainId till leaves.
        /// </summary>
        public bool? Isrecursive {
            get { return GetParameterValue<bool?>(nameof(Isrecursive).ToLower()); }
            set { SetParameterValue(nameof(Isrecursive).ToLower(), value); }
        }

        /// <summary>
        /// true if network is system, false otherwise
        /// </summary>
        public bool? IsSystem {
            get { return GetParameterValue<bool?>(nameof(IsSystem).ToLower()); }
            set { SetParameterValue(nameof(IsSystem).ToLower(), value); }
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
        /// list networks by physical network id
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
        /// list networks by restartRequired
        /// </summary>
        public bool? RestartRequired {
            get { return GetParameterValue<bool?>(nameof(RestartRequired).ToLower()); }
            set { SetParameterValue(nameof(RestartRequired).ToLower(), value); }
        }

        /// <summary>
        /// true if need to list only networks which support specifying IP ranges
        /// </summary>
        public bool? SpecifyIpRanges {
            get { return GetParameterValue<bool?>(nameof(SpecifyIpRanges).ToLower()); }
            set { SetParameterValue(nameof(SpecifyIpRanges).ToLower(), value); }
        }

        /// <summary>
        /// list networks supporting certain services
        /// </summary>
        public IList<string> SupportedServices {
            get { return GetList<string>(nameof(SupportedServices).ToLower()); }
            set { SetParameterValue(nameof(SupportedServices).ToLower(), value); }
        }

        /// <summary>
        /// List resources by tags (key/value pairs)
        /// </summary>
        public IList<IDictionary<string, object>> Tags {
            get { return GetList<IDictionary<string, object>>(nameof(Tags).ToLower()); }
            set { SetParameterValue(nameof(Tags).ToLower(), value); }
        }

        /// <summary>
        /// type of the traffic
        /// </summary>
        public string TrafficType {
            get { return GetParameterValue<string>(nameof(TrafficType).ToLower()); }
            set { SetParameterValue(nameof(TrafficType).ToLower(), value); }
        }

        /// <summary>
        /// the type of the network. Supported values are: isolated and shared
        /// </summary>
        public string Type {
            get { return GetParameterValue<string>(nameof(Type).ToLower()); }
            set { SetParameterValue(nameof(Type).ToLower(), value); }
        }

        /// <summary>
        /// List networks by VPC
        /// </summary>
        public Guid? VpcId {
            get { return GetParameterValue<Guid?>(nameof(VpcId).ToLower()); }
            set { SetParameterValue(nameof(VpcId).ToLower(), value); }
        }

        /// <summary>
        /// the zone ID of the network
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists all available networks.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<NetworkResponse> ListNetworks(ListNetworksRequest request);
        Task<ListResponse<NetworkResponse>> ListNetworksAsync(ListNetworksRequest request);
        ListResponse<NetworkResponse> ListNetworksAllPages(ListNetworksRequest request);
        Task<ListResponse<NetworkResponse>> ListNetworksAllPagesAsync(ListNetworksRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<NetworkResponse> ListNetworks(ListNetworksRequest request) => Proxy.Request<ListResponse<NetworkResponse>>(request);
        public Task<ListResponse<NetworkResponse>> ListNetworksAsync(ListNetworksRequest request) => Proxy.RequestAsync<ListResponse<NetworkResponse>>(request);
        public ListResponse<NetworkResponse> ListNetworksAllPages(ListNetworksRequest request) => Proxy.RequestAllPages<NetworkResponse>(request);
        public Task<ListResponse<NetworkResponse>> ListNetworksAllPagesAsync(ListNetworksRequest request) => Proxy.RequestAllPagesAsync<NetworkResponse>(request);
    }
}
