using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListUsersRequest : APIListRequest
    {
        public ListUsersRequest() : base("listUsers") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// List users by account type. Valid types include admin, domain-admin, read-only-admin, or user.
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
        /// List user by ID.
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
        /// List users by state of the user account.
        /// </summary>
        public string State {
            get { return GetParameterValue<string>(nameof(State).ToLower()); }
            set { SetParameterValue(nameof(State).ToLower(), value); }
        }

        /// <summary>
        /// List user by the username
        /// </summary>
        public string Username {
            get { return GetParameterValue<string>(nameof(Username).ToLower()); }
            set { SetParameterValue(nameof(Username).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists user accounts
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<UserResponse> ListUsers(ListUsersRequest request);
        Task<ListResponse<UserResponse>> ListUsersAsync(ListUsersRequest request);
        ListResponse<UserResponse> ListUsersAllPages(ListUsersRequest request);
        Task<ListResponse<UserResponse>> ListUsersAllPagesAsync(ListUsersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<UserResponse> ListUsers(ListUsersRequest request) => _proxy.Request<ListResponse<UserResponse>>(request);
        public Task<ListResponse<UserResponse>> ListUsersAsync(ListUsersRequest request) => _proxy.RequestAsync<ListResponse<UserResponse>>(request);
        public ListResponse<UserResponse> ListUsersAllPages(ListUsersRequest request) => _proxy.RequestAllPages<UserResponse>(request);
        public Task<ListResponse<UserResponse>> ListUsersAllPagesAsync(ListUsersRequest request) => _proxy.RequestAllPagesAsync<UserResponse>(request);
    }
}
