using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListAutoScalePoliciesRequest : APIRequest
    {
        public ListAutoScalePoliciesRequest() : base("listAutoScalePolicies") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// the action to be executed if all the conditions evaluate to true for the specified duration.
        /// </summary>
        public string Action {
            get { return (string) Parameters[nameof(Action).ToLower()]; }
            set { Parameters[nameof(Action).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the condition of the policy
        /// </summary>
        public Guid ConditionId {
            get { return (Guid) Parameters[nameof(ConditionId).ToLower()]; }
            set { Parameters[nameof(ConditionId).ToLower()] = value; }
        }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the autoscale policy
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
        /// the ID of the autoscale vm group
        /// </summary>
        public Guid VmGroupId {
            get { return (Guid) Parameters[nameof(VmGroupId).ToLower()]; }
            set { Parameters[nameof(VmGroupId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists autoscale policies.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<AutoScalePolicyResponse> ListAutoScalePolicies(ListAutoScalePoliciesRequest request);
        Task<ListResponse<AutoScalePolicyResponse>> ListAutoScalePoliciesAsync(ListAutoScalePoliciesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<AutoScalePolicyResponse> ListAutoScalePolicies(ListAutoScalePoliciesRequest request) => _proxy.Request<ListResponse<AutoScalePolicyResponse>>(request);
        public Task<ListResponse<AutoScalePolicyResponse>> ListAutoScalePoliciesAsync(ListAutoScalePoliciesRequest request) => _proxy.RequestAsync<ListResponse<AutoScalePolicyResponse>>(request);
    }
}
