using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListInstanceGroupsRequest : APIListRequest
    {
        public ListInstanceGroupsRequest() : base("listInstanceGroups") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// list instance groups by ID
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
        /// list instance groups by name
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// list objects by project
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists vm groups
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<InstanceGroupResponse> ListInstanceGroups(ListInstanceGroupsRequest request);
        Task<ListResponse<InstanceGroupResponse>> ListInstanceGroupsAsync(ListInstanceGroupsRequest request);
        ListResponse<InstanceGroupResponse> ListInstanceGroupsAllPages(ListInstanceGroupsRequest request);
        Task<ListResponse<InstanceGroupResponse>> ListInstanceGroupsAllPagesAsync(ListInstanceGroupsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<InstanceGroupResponse> ListInstanceGroups(ListInstanceGroupsRequest request) => Proxy.Request<ListResponse<InstanceGroupResponse>>(request);
        public Task<ListResponse<InstanceGroupResponse>> ListInstanceGroupsAsync(ListInstanceGroupsRequest request) => Proxy.RequestAsync<ListResponse<InstanceGroupResponse>>(request);
        public ListResponse<InstanceGroupResponse> ListInstanceGroupsAllPages(ListInstanceGroupsRequest request) => Proxy.RequestAllPages<InstanceGroupResponse>(request);
        public Task<ListResponse<InstanceGroupResponse>> ListInstanceGroupsAllPagesAsync(ListInstanceGroupsRequest request) => Proxy.RequestAllPagesAsync<InstanceGroupResponse>(request);
    }
}
