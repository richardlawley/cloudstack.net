using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class LdapCreateAccountRequest : APIRequest
    {
        public LdapCreateAccountRequest() : base("ldapCreateAccount") {}

        /// <summary>
        /// Type of the account.  Specify 0 for user, 1 for root admin, and 2 for domain admin
        /// </summary>
        public short AccountType {
            get { return GetParameterValue<short>(nameof(AccountType).ToLower()); }
            set { SetParameterValue(nameof(AccountType).ToLower(), value); }
        }

        /// <summary>
        /// Unique username.
        /// </summary>
        public string Username {
            get { return GetParameterValue<string>(nameof(Username).ToLower()); }
            set { SetParameterValue(nameof(Username).ToLower(), value); }
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
        /// Account UUID, required for adding account from external provisioning system
        /// </summary>
        public string Accountid {
            get { return GetParameterValue<string>(nameof(Accountid).ToLower()); }
            set { SetParameterValue(nameof(Accountid).ToLower(), value); }
        }

        /// <summary>
        /// Creates the user under the specified domain.
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// Network domain for the account's networks
        /// </summary>
        public string NetworkDomain {
            get { return GetParameterValue<string>(nameof(NetworkDomain).ToLower()); }
            set { SetParameterValue(nameof(NetworkDomain).ToLower(), value); }
        }

        /// <summary>
        /// Specifies a timezone for this command. For more information on the timezone parameter, see Time Zone Format.
        /// </summary>
        public string Timezone {
            get { return GetParameterValue<string>(nameof(Timezone).ToLower()); }
            set { SetParameterValue(nameof(Timezone).ToLower(), value); }
        }

        /// <summary>
        /// User UUID, required for adding account from external provisioning system
        /// </summary>
        public string Userid {
            get { return GetParameterValue<string>(nameof(Userid).ToLower()); }
            set { SetParameterValue(nameof(Userid).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates an account from an LDAP user
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AccountResponse LdapCreateAccount(LdapCreateAccountRequest request);
        Task<AccountResponse> LdapCreateAccountAsync(LdapCreateAccountRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AccountResponse LdapCreateAccount(LdapCreateAccountRequest request) => Proxy.Request<AccountResponse>(request);
        public Task<AccountResponse> LdapCreateAccountAsync(LdapCreateAccountRequest request) => Proxy.RequestAsync<AccountResponse>(request);
    }
}
