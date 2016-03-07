using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListLdapUsersRequest : APIListRequest
    {
        public ListLdapUsersRequest() : base("listLdapUsers") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        /// <summary>
        /// Determines whether all ldap users are returned or just non-cloudstack users
        /// </summary>
        public string ListType {
            get { return (string) Parameters[nameof(ListType).ToLower()]; }
            set { Parameters[nameof(ListType).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists all LDAP Users
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<LdapUserResponse> ListLdapUsers(ListLdapUsersRequest request);
        Task<ListResponse<LdapUserResponse>> ListLdapUsersAsync(ListLdapUsersRequest request);
        ListResponse<LdapUserResponse> ListLdapUsersAllPages(ListLdapUsersRequest request);
        Task<ListResponse<LdapUserResponse>> ListLdapUsersAllPagesAsync(ListLdapUsersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<LdapUserResponse> ListLdapUsers(ListLdapUsersRequest request) => _proxy.Request<ListResponse<LdapUserResponse>>(request);
        public Task<ListResponse<LdapUserResponse>> ListLdapUsersAsync(ListLdapUsersRequest request) => _proxy.RequestAsync<ListResponse<LdapUserResponse>>(request);
        public ListResponse<LdapUserResponse> ListLdapUsersAllPages(ListLdapUsersRequest request) => _proxy.RequestAllPages<LdapUserResponse>(request);
        public Task<ListResponse<LdapUserResponse>> ListLdapUsersAllPagesAsync(ListLdapUsersRequest request) => _proxy.RequestAllPagesAsync<LdapUserResponse>(request);
    }
}
