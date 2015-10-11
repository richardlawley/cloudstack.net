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
        public short AccountType {
            get { return (short) Parameters[nameof(AccountType).ToLower()]; }
            set { Parameters[nameof(AccountType).ToLower()] = value; }
        }

        /// <summary>
        /// Creates the user under the specified account. If no account is specified, the username will be used as the account name.
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// details for account used to store specific parameters
        /// </summary>
        public IList<IDictionary<string, object>> Accountdetails {
            get { return (IList<IDictionary<string, object>>) Parameters[nameof(Accountdetails).ToLower()]; }
            set { Parameters[nameof(Accountdetails).ToLower()] = value; }
        }

        /// <summary>
        /// Specifies the domain to which the ldap users are to be imported. If no domain is specified, a domain will created using group parameter. If the group is also not specified, a domain name based on the OU information will be created. If no OU hierarchy exists, will be defaulted to ROOT domain
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// Specifies the group name from which the ldap users are to be imported. If no group is specified, all the users will be imported.
        /// </summary>
        public string Group {
            get { return (string) Parameters[nameof(Group).ToLower()]; }
            set { Parameters[nameof(Group).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
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
        /// Specifies a timezone for this command. For more information on the timezone parameter, see Time Zone Format.
        /// </summary>
        public string Timezone {
            get { return (string) Parameters[nameof(Timezone).ToLower()]; }
            set { Parameters[nameof(Timezone).ToLower()] = value; }
        }

    }
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
