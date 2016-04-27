using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListAffinityGroupsRequest : APIListRequest
    {
        public ListAffinityGroupsRequest() : base("listAffinityGroups") {}

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
        /// list the affinity group by the ID provided
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
        /// lists affinity groups by name
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

        /// <summary>
        /// lists affinity groups by type
        /// </summary>
        public string Type {
            get { return GetParameterValue<string>(nameof(Type).ToLower()); }
            set { SetParameterValue(nameof(Type).ToLower(), value); }
        }

        /// <summary>
        /// lists affinity groups by virtual machine ID
        /// </summary>
        public Guid? VirtualMachineId {
            get { return GetParameterValue<Guid?>(nameof(VirtualMachineId).ToLower()); }
            set { SetParameterValue(nameof(VirtualMachineId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists affinity groups
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<AffinityGroupResponse> ListAffinityGroups(ListAffinityGroupsRequest request);
        Task<ListResponse<AffinityGroupResponse>> ListAffinityGroupsAsync(ListAffinityGroupsRequest request);
        ListResponse<AffinityGroupResponse> ListAffinityGroupsAllPages(ListAffinityGroupsRequest request);
        Task<ListResponse<AffinityGroupResponse>> ListAffinityGroupsAllPagesAsync(ListAffinityGroupsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<AffinityGroupResponse> ListAffinityGroups(ListAffinityGroupsRequest request) => _proxy.Request<ListResponse<AffinityGroupResponse>>(request);
        public Task<ListResponse<AffinityGroupResponse>> ListAffinityGroupsAsync(ListAffinityGroupsRequest request) => _proxy.RequestAsync<ListResponse<AffinityGroupResponse>>(request);
        public ListResponse<AffinityGroupResponse> ListAffinityGroupsAllPages(ListAffinityGroupsRequest request) => _proxy.RequestAllPages<AffinityGroupResponse>(request);
        public Task<ListResponse<AffinityGroupResponse>> ListAffinityGroupsAllPagesAsync(ListAffinityGroupsRequest request) => _proxy.RequestAllPagesAsync<AffinityGroupResponse>(request);
    }
}
