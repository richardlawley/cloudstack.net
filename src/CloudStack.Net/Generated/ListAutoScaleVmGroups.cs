using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListAutoScaleVmGroupsRequest : APIListRequest
    {
        public ListAutoScaleVmGroupsRequest() : base("listAutoScaleVmGroups") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
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
        /// the ID of the autoscale vm group
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
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the loadbalancer
        /// </summary>
        public Guid Lbruleid {
            get { return (Guid) Parameters[nameof(Lbruleid).ToLower()]; }
            set { Parameters[nameof(Lbruleid).ToLower()] = value; }
        }

        /// <summary>
        /// If set to false, list only resources belonging to the command's caller; if set to true - list resources that the caller is authorized to see. Default value is false
        /// </summary>
        public bool? ListAll {
            get { return (bool?) Parameters[nameof(ListAll).ToLower()]; }
            set { Parameters[nameof(ListAll).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the policy
        /// </summary>
        public Guid PolicyId {
            get { return (Guid) Parameters[nameof(PolicyId).ToLower()]; }
            set { Parameters[nameof(PolicyId).ToLower()] = value; }
        }

        /// <summary>
        /// list objects by project
        /// </summary>
        public Guid ProjectId {
            get { return (Guid) Parameters[nameof(ProjectId).ToLower()]; }
            set { Parameters[nameof(ProjectId).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the profile
        /// </summary>
        public Guid Vmprofileid {
            get { return (Guid) Parameters[nameof(Vmprofileid).ToLower()]; }
            set { Parameters[nameof(Vmprofileid).ToLower()] = value; }
        }

        /// <summary>
        /// the availability zone ID
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists autoscale vm groups.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<AutoScaleVmGroupResponse> ListAutoScaleVmGroups(ListAutoScaleVmGroupsRequest request);
        Task<ListResponse<AutoScaleVmGroupResponse>> ListAutoScaleVmGroupsAsync(ListAutoScaleVmGroupsRequest request);
        ListResponse<AutoScaleVmGroupResponse> ListAutoScaleVmGroupsAllPages(ListAutoScaleVmGroupsRequest request);
        Task<ListResponse<AutoScaleVmGroupResponse>> ListAutoScaleVmGroupsAllPagesAsync(ListAutoScaleVmGroupsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<AutoScaleVmGroupResponse> ListAutoScaleVmGroups(ListAutoScaleVmGroupsRequest request) => _proxy.Request<ListResponse<AutoScaleVmGroupResponse>>(request);
        public Task<ListResponse<AutoScaleVmGroupResponse>> ListAutoScaleVmGroupsAsync(ListAutoScaleVmGroupsRequest request) => _proxy.RequestAsync<ListResponse<AutoScaleVmGroupResponse>>(request);
        public ListResponse<AutoScaleVmGroupResponse> ListAutoScaleVmGroupsAllPages(ListAutoScaleVmGroupsRequest request) => _proxy.RequestAllPages<AutoScaleVmGroupResponse>(request);
        public Task<ListResponse<AutoScaleVmGroupResponse>> ListAutoScaleVmGroupsAllPagesAsync(ListAutoScaleVmGroupsRequest request) => _proxy.RequestAllPagesAsync<AutoScaleVmGroupResponse>(request);
    }
}
