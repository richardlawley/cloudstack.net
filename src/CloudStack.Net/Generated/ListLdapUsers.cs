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
        public string Keyword { get; set; }

        /// <summary>
        /// Determines whether all ldap users are returned or just non-cloudstack users
        /// </summary>
        public string ListType { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

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
