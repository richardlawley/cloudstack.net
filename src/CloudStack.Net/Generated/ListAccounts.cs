using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListAccountsRequest : APIRequest
    {
        public ListAccountsRequest() : base("listAccounts") {}

        /// <summary>
        /// list accounts by account type. Valid account types are 1 (admin), 2 (domain-admin), and 0 (user).
        /// </summary>
        public long? AccountType { get; set; }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// list account by account ID
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// list accounts by cleanuprequired attribute (values are true or false)
        /// </summary>
        public bool? CleanupRequired { get; set; }

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

        /// <summary>
        /// list account by account name
        /// </summary>
        public string SearchName { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// list accounts by state. Valid states are enabled, disabled, and locked.
        /// </summary>
        public string State { get; set; }

    }
    /// <summary>
    /// Lists accounts and provides detailed account information for listed accounts
    /// </summary>
    /// <summary>
    /// Lists accounts and provides detailed account information for listed accounts
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<AccountResponse> ListAccounts(ListAccountsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<AccountResponse> ListAccounts(ListAccountsRequest request) => _proxy.Request<ListResponse<AccountResponse>>(request);
    }
}
