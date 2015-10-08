using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ImportLdapUsersRequest : APIRequest
    {
        public ImportLdapUsersRequest() : base("importLdapUsers") {}

        /// <summary>
        /// Type of the account.  Specify 0 for user, 1 for root admin, and 2 for domain admin
        /// </summary>
        public short AccountType { get; set; }

        /// <summary>
        /// Creates the user under the specified account. If no account is specified, the username will be used as the account name.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// details for account used to store specific parameters
        /// </summary>
        public IDictionary<string, string> Details { get; set; }

        /// <summary>
        /// Specifies the domain to which the ldap users are to be imported. If no domain is specified, a domain will created using group parameter. If the group is also not specified, a domain name based on the OU information will be created. If no OU hierarchy exists, will be defaulted to ROOT domain
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// Specifies the group name from which the ldap users are to be imported. If no group is specified, all the users will be imported.
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// Specifies a timezone for this command. For more information on the timezone parameter, see Time Zone Format.
        /// </summary>
        public string Timezone { get; set; }

    }
    /// <summary>
    /// Import LDAP users
    /// </summary>
    /// <summary>
    /// Import LDAP users
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<LdapUserResponse> ImportLdapUsers(ImportLdapUsersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<LdapUserResponse> ImportLdapUsers(ImportLdapUsersRequest request) => _proxy.Request<ListResponse<LdapUserResponse>>(request);
    }
}
