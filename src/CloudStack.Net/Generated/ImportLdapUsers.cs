using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ImportLdapUsersRequest : APIListRequest
    {
        public ImportLdapUsersRequest() : base("importLdapUsers") {}

        /// <summary>
        /// Type of the account.  Specify 0 for user, 1 for root admin, and 2 for domain admin
        /// </summary>
        public short AccountType {
            get { return GetParameterValue<short>(nameof(AccountType).ToLower()); }
            set { SetParameterValue(nameof(AccountType).ToLower(), value); }
        }

        /// <summary>
        /// Creates the user under the specified account. If no account is specified, the username will be used as the account name.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// details for account used to store specific parameters
        /// </summary>
        public IList<IDictionary<string, object>> Accountdetails {
            get { return GetList<IDictionary<string, object>>(nameof(Accountdetails).ToLower()); }
            set { SetParameterValue(nameof(Accountdetails).ToLower(), value); }
        }

        /// <summary>
        /// Specifies the domain to which the ldap users are to be imported. If no domain is specified, a domain will created using group parameter. If the group is also not specified, a domain name based on the OU information will be created. If no OU hierarchy exists, will be defaulted to ROOT domain
        /// </summary>
        public Guid DomainId {
            get { return GetParameterValue<Guid>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// Specifies the group name from which the ldap users are to be imported. If no group is specified, all the users will be imported.
        /// </summary>
        public string Group {
            get { return GetParameterValue<string>(nameof(Group).ToLower()); }
            set { SetParameterValue(nameof(Group).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// Specifies a timezone for this command. For more information on the timezone parameter, see Time Zone Format.
        /// </summary>
        public string Timezone {
            get { return GetParameterValue<string>(nameof(Timezone).ToLower()); }
            set { SetParameterValue(nameof(Timezone).ToLower(), value); }
        }

    }
    /// <summary>
    /// Import LDAP users
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<LdapUserResponse> ImportLdapUsers(ImportLdapUsersRequest request);
        Task<ListResponse<LdapUserResponse>> ImportLdapUsersAsync(ImportLdapUsersRequest request);
        ListResponse<LdapUserResponse> ImportLdapUsersAllPages(ImportLdapUsersRequest request);
        Task<ListResponse<LdapUserResponse>> ImportLdapUsersAllPagesAsync(ImportLdapUsersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<LdapUserResponse> ImportLdapUsers(ImportLdapUsersRequest request) => _proxy.Request<ListResponse<LdapUserResponse>>(request);
        public Task<ListResponse<LdapUserResponse>> ImportLdapUsersAsync(ImportLdapUsersRequest request) => _proxy.RequestAsync<ListResponse<LdapUserResponse>>(request);
        public ListResponse<LdapUserResponse> ImportLdapUsersAllPages(ImportLdapUsersRequest request) => _proxy.RequestAllPages<LdapUserResponse>(request);
        public Task<ListResponse<LdapUserResponse>> ImportLdapUsersAllPagesAsync(ImportLdapUsersRequest request) => _proxy.RequestAllPagesAsync<LdapUserResponse>(request);
    }
}
