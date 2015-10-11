using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListLdapUsersRequest : APIRequest
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

        public int? Page {
            get { return (int?) Parameters[nameof(Page).ToLower()]; }
            set { Parameters[nameof(Page).ToLower()] = value; }
        }

        public int? PageSize {
            get { return (int?) Parameters[nameof(PageSize).ToLower()]; }
            set { Parameters[nameof(PageSize).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists all LDAP Users
    /// </summary>
    /// <summary>
    /// Lists all LDAP Users
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<LdapUserResponse> ListLdapUsers(ListLdapUsersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<LdapUserResponse> ListLdapUsers(ListLdapUsersRequest request) => _proxy.Request<ListResponse<LdapUserResponse>>(request);
    }
}
