using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListAccountsRequest : APIListRequest
    {
        public ListAccountsRequest() : base("listAccounts") {}

        /// <summary>
        /// list accounts by account type. Valid account types are 1 (admin), 2 (domain-admin), and 0 (user).
        /// </summary>
        public long? AccountType {
            get { return GetParameterValue<long?>(nameof(AccountType).ToLower()); }
            set { SetParameterValue(nameof(AccountType).ToLower(), value); }
        }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId {
            get { return GetParameterValue<Guid>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// list account by account ID
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// list accounts by cleanuprequired attribute (values are true or false)
        /// </summary>
        public bool? Iscleanuprequired {
            get { return GetParameterValue<bool?>(nameof(Iscleanuprequired).ToLower()); }
            set { SetParameterValue(nameof(Iscleanuprequired).ToLower(), value); }
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
        /// list account by account name
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// list accounts by state. Valid states are enabled, disabled, and locked.
        /// </summary>
        public string State {
            get { return GetParameterValue<string>(nameof(State).ToLower()); }
            set { SetParameterValue(nameof(State).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists accounts and provides detailed account information for listed accounts
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<AccountResponse> ListAccounts(ListAccountsRequest request);
        Task<ListResponse<AccountResponse>> ListAccountsAsync(ListAccountsRequest request);
        ListResponse<AccountResponse> ListAccountsAllPages(ListAccountsRequest request);
        Task<ListResponse<AccountResponse>> ListAccountsAllPagesAsync(ListAccountsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<AccountResponse> ListAccounts(ListAccountsRequest request) => _proxy.Request<ListResponse<AccountResponse>>(request);
        public Task<ListResponse<AccountResponse>> ListAccountsAsync(ListAccountsRequest request) => _proxy.RequestAsync<ListResponse<AccountResponse>>(request);
        public ListResponse<AccountResponse> ListAccountsAllPages(ListAccountsRequest request) => _proxy.RequestAllPages<AccountResponse>(request);
        public Task<ListResponse<AccountResponse>> ListAccountsAllPagesAsync(ListAccountsRequest request) => _proxy.RequestAllPagesAsync<AccountResponse>(request);
    }
}
