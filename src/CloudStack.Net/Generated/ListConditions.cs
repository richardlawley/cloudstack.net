using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListConditionsRequest : APIRequest
    {
        public ListConditionsRequest() : base("listConditions") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// Counter-id of the condition.
        /// </summary>
        public Guid CounterId {
            get { return (Guid) Parameters[nameof(CounterId).ToLower()]; }
            set { Parameters[nameof(CounterId).ToLower()] = value; }
        }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// ID of the Condition.
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
        /// the ID of the policy
        /// </summary>
        public Guid PolicyId {
            get { return (Guid) Parameters[nameof(PolicyId).ToLower()]; }
            set { Parameters[nameof(PolicyId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// List Conditions for the specific user
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ConditionResponse> ListConditions(ListConditionsRequest request);
        Task<ListResponse<ConditionResponse>> ListConditionsAsync(ListConditionsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ConditionResponse> ListConditions(ListConditionsRequest request) => _proxy.Request<ListResponse<ConditionResponse>>(request);
        public Task<ListResponse<ConditionResponse>> ListConditionsAsync(ListConditionsRequest request) => _proxy.RequestAsync<ListResponse<ConditionResponse>>(request);
    }
}
