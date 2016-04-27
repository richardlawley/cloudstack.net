using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListRoutersRequest : APIListRequest
    {
        public ListRoutersRequest() : base("listRouters") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// the cluster ID of the router
        /// </summary>
        public Guid? ClusterId {
            get { return GetParameterValue<Guid?>(nameof(ClusterId).ToLower()); }
            set { SetParameterValue(nameof(ClusterId).ToLower(), value); }
        }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// if true is passed for this parameter, list only VPC routers
        /// </summary>
        public bool? ForVpc {
            get { return GetParameterValue<bool?>(nameof(ForVpc).ToLower()); }
            set { SetParameterValue(nameof(ForVpc).ToLower(), value); }
        }

        /// <summary>
        /// the host ID of the router
        /// </summary>
        public Guid? HostId {
            get { return GetParameterValue<Guid?>(nameof(HostId).ToLower()); }
            set { SetParameterValue(nameof(HostId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the disk router
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
        /// the name of the router
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// list by network id
        /// </summary>
        public Guid? NetworkId {
            get { return GetParameterValue<Guid?>(nameof(NetworkId).ToLower()); }
            set { SetParameterValue(nameof(NetworkId).ToLower(), value); }
        }

        /// <summary>
        /// the Pod ID of the router
        /// </summary>
        public Guid? PodId {
            get { return GetParameterValue<Guid?>(nameof(PodId).ToLower()); }
            set { SetParameterValue(nameof(PodId).ToLower(), value); }
        }

        /// <summary>
        /// list objects by project
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// the state of the router
        /// </summary>
        public string State {
            get { return GetParameterValue<string>(nameof(State).ToLower()); }
            set { SetParameterValue(nameof(State).ToLower(), value); }
        }

        /// <summary>
        /// list virtual router elements by version
        /// </summary>
        public string Version {
            get { return GetParameterValue<string>(nameof(Version).ToLower()); }
            set { SetParameterValue(nameof(Version).ToLower(), value); }
        }

        /// <summary>
        /// List networks by VPC
        /// </summary>
        public Guid? VpcId {
            get { return GetParameterValue<Guid?>(nameof(VpcId).ToLower()); }
            set { SetParameterValue(nameof(VpcId).ToLower(), value); }
        }

        /// <summary>
        /// the Zone ID of the router
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// List routers.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<DomainRouterResponse> ListRouters(ListRoutersRequest request);
        Task<ListResponse<DomainRouterResponse>> ListRoutersAsync(ListRoutersRequest request);
        ListResponse<DomainRouterResponse> ListRoutersAllPages(ListRoutersRequest request);
        Task<ListResponse<DomainRouterResponse>> ListRoutersAllPagesAsync(ListRoutersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<DomainRouterResponse> ListRouters(ListRoutersRequest request) => _proxy.Request<ListResponse<DomainRouterResponse>>(request);
        public Task<ListResponse<DomainRouterResponse>> ListRoutersAsync(ListRoutersRequest request) => _proxy.RequestAsync<ListResponse<DomainRouterResponse>>(request);
        public ListResponse<DomainRouterResponse> ListRoutersAllPages(ListRoutersRequest request) => _proxy.RequestAllPages<DomainRouterResponse>(request);
        public Task<ListResponse<DomainRouterResponse>> ListRoutersAllPagesAsync(ListRoutersRequest request) => _proxy.RequestAllPagesAsync<DomainRouterResponse>(request);
    }
}
