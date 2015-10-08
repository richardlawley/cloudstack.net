using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListConditionsRequest : APIRequest
    {
        public ListConditionsRequest() : base("listConditions") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// Counter-id of the condition.
        /// </summary>
        public Guid CounterId { get; set; }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// ID of the Condition.
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
        /// the ID of the policy
        /// </summary>
        public Guid PolicyId { get; set; }

    }
    /// <summary>
    /// List Conditions for the specific user
    /// </summary>
    /// <summary>
    /// List Conditions for the specific user
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ConditionResponse> ListConditions(ListConditionsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ConditionResponse> ListConditions(ListConditionsRequest request) => _proxy.Request<ListResponse<ConditionResponse>>(request);
    }
}
