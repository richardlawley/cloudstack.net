using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListAutoScalePoliciesRequest : APIRequest
    {
        public ListAutoScalePoliciesRequest() : base("listAutoScalePolicies") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// the action to be executed if all the conditions evaluate to true for the specified duration.
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// the ID of the condition of the policy
        /// </summary>
        public Guid ConditionId { get; set; }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// the ID of the autoscale policy
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// defaults to false, but if true, lists all resources from the parent specified by the domainId till leaves.
        /// </summary>
        public bool? Recursive { get; set; }

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
        /// the ID of the autoscale vm group
        /// </summary>
        public Guid VmGroupId { get; set; }

    }
    /// <summary>
    /// Lists autoscale policies.
    /// </summary>
    /// <summary>
    /// Lists autoscale policies.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<AutoScalePolicyResponse> ListAutoScalePolicies(ListAutoScalePoliciesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<AutoScalePolicyResponse> ListAutoScalePolicies(ListAutoScalePoliciesRequest request) => _proxy.Request<ListResponse<AutoScalePolicyResponse>>(request);
    }
}
