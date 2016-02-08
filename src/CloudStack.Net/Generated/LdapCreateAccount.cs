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
            get { return (short) Parameters[nameof(AccountType).ToLower()]; }
            set { Parameters[nameof(AccountType).ToLower()] = value; }
        }

        /// <summary>
        /// Unique username.
        /// </summary>
        public string Username {
            get { return (string) Parameters[nameof(Username).ToLower()]; }
            set { Parameters[nameof(Username).ToLower()] = value; }
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
            get { return GetList<IDictionary<string, object>>(nameof(Accountdetails).ToLower()); }
            set { Parameters[nameof(Accountdetails).ToLower()] = value; }
        }

        /// <summary>
        /// Account UUID, required for adding account from external provisioning system
        /// </summary>
        public string Accountid {
            get { return (string) Parameters[nameof(Accountid).ToLower()]; }
            set { Parameters[nameof(Accountid).ToLower()] = value; }
        }

        /// <summary>
        /// Creates the user under the specified domain.
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// Network domain for the account's networks
        /// </summary>
        public string NetworkDomain {
            get { return (string) Parameters[nameof(NetworkDomain).ToLower()]; }
            set { Parameters[nameof(NetworkDomain).ToLower()] = value; }
        }

        /// <summary>
        /// Specifies a timezone for this command. For more information on the timezone parameter, see Time Zone Format.
        /// </summary>
        public string Timezone {
            get { return (string) Parameters[nameof(Timezone).ToLower()]; }
            set { Parameters[nameof(Timezone).ToLower()] = value; }
        }

        /// <summary>
        /// User UUID, required for adding account from external provisioning system
        /// </summary>
        public string Userid {
            get { return (string) Parameters[nameof(Userid).ToLower()]; }
            set { Parameters[nameof(Userid).ToLower()] = value; }
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
        public AccountResponse LdapCreateAccount(LdapCreateAccountRequest request) => _proxy.Request<AccountResponse>(request);
        public Task<AccountResponse> LdapCreateAccountAsync(LdapCreateAccountRequest request) => _proxy.RequestAsync<AccountResponse>(request);
    }
}
