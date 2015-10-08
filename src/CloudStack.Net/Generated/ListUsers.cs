using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListUsersRequest : APIRequest
    {
        public ListUsersRequest() : base("listUsers") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// List users by account type. Valid types include admin, domain-admin, read-only-admin, or user.
        /// </summary>
        public long? AccountType { get; set; }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// List user by ID.
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
        /// List users by state of the user account.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// List user by the username
        /// </summary>
        public string Username { get; set; }

    }
    /// <summary>
    /// Lists user accounts
    /// </summary>
    /// <summary>
    /// Lists user accounts
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<UserResponse> ListUsers(ListUsersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<UserResponse> ListUsers(ListUsersRequest request) => _proxy.Request<ListResponse<UserResponse>>(request);
    }
}
