using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListConditionsRequest : APIListRequest
    {
        public ListConditionsRequest() : base("listConditions") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// Counter-id of the condition.
        /// </summary>
        public Guid CounterId {
            get { return GetParameterValue<Guid>(nameof(CounterId).ToLower()); }
            set { SetParameterValue(nameof(CounterId).ToLower(), value); }
        }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId {
            get { return GetParameterValue<Guid>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// ID of the Condition.
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
        /// the ID of the policy
        /// </summary>
        public Guid PolicyId {
            get { return GetParameterValue<Guid>(nameof(PolicyId).ToLower()); }
            set { SetParameterValue(nameof(PolicyId).ToLower(), value); }
        }

    }
    /// <summary>
    /// List Conditions for the specific user
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ConditionResponse> ListConditions(ListConditionsRequest request);
        Task<ListResponse<ConditionResponse>> ListConditionsAsync(ListConditionsRequest request);
        ListResponse<ConditionResponse> ListConditionsAllPages(ListConditionsRequest request);
        Task<ListResponse<ConditionResponse>> ListConditionsAllPagesAsync(ListConditionsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ConditionResponse> ListConditions(ListConditionsRequest request) => _proxy.Request<ListResponse<ConditionResponse>>(request);
        public Task<ListResponse<ConditionResponse>> ListConditionsAsync(ListConditionsRequest request) => _proxy.RequestAsync<ListResponse<ConditionResponse>>(request);
        public ListResponse<ConditionResponse> ListConditionsAllPages(ListConditionsRequest request) => _proxy.RequestAllPages<ConditionResponse>(request);
        public Task<ListResponse<ConditionResponse>> ListConditionsAllPagesAsync(ListConditionsRequest request) => _proxy.RequestAllPagesAsync<ConditionResponse>(request);
    }
}
