using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListAutoScalePoliciesRequest : APIListRequest
    {
        public ListAutoScalePoliciesRequest() : base("listAutoScalePolicies") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// the action to be executed if all the conditions evaluate to true for the specified duration.
        /// </summary>
        public string Action {
            get { return GetParameterValue<string>(nameof(Action).ToLower()); }
            set { SetParameterValue(nameof(Action).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the condition of the policy
        /// </summary>
        public Guid ConditionId {
            get { return GetParameterValue<Guid>(nameof(ConditionId).ToLower()); }
            set { SetParameterValue(nameof(ConditionId).ToLower(), value); }
        }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId {
            get { return GetParameterValue<Guid>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the autoscale policy
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
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
        /// the ID of the autoscale vm group
        /// </summary>
        public Guid VmGroupId {
            get { return GetParameterValue<Guid>(nameof(VmGroupId).ToLower()); }
            set { SetParameterValue(nameof(VmGroupId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists autoscale policies.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<AutoScalePolicyResponse> ListAutoScalePolicies(ListAutoScalePoliciesRequest request);
        Task<ListResponse<AutoScalePolicyResponse>> ListAutoScalePoliciesAsync(ListAutoScalePoliciesRequest request);
        ListResponse<AutoScalePolicyResponse> ListAutoScalePoliciesAllPages(ListAutoScalePoliciesRequest request);
        Task<ListResponse<AutoScalePolicyResponse>> ListAutoScalePoliciesAllPagesAsync(ListAutoScalePoliciesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<AutoScalePolicyResponse> ListAutoScalePolicies(ListAutoScalePoliciesRequest request) => _proxy.Request<ListResponse<AutoScalePolicyResponse>>(request);
        public Task<ListResponse<AutoScalePolicyResponse>> ListAutoScalePoliciesAsync(ListAutoScalePoliciesRequest request) => _proxy.RequestAsync<ListResponse<AutoScalePolicyResponse>>(request);
        public ListResponse<AutoScalePolicyResponse> ListAutoScalePoliciesAllPages(ListAutoScalePoliciesRequest request) => _proxy.RequestAllPages<AutoScalePolicyResponse>(request);
        public Task<ListResponse<AutoScalePolicyResponse>> ListAutoScalePoliciesAllPagesAsync(ListAutoScalePoliciesRequest request) => _proxy.RequestAllPagesAsync<AutoScalePolicyResponse>(request);
    }
}
