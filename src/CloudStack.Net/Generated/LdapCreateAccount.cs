using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class LdapCreateAccountRequest : APIRequest
    {
        public LdapCreateAccountRequest() : base("ldapCreateAccount") {}

        /// <summary>
        /// Type of the account.  Specify 0 for user, 1 for root admin, and 2 for domain admin
        /// </summary>
        public short AccountType { get; set; }

        /// <summary>
        /// Unique username.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Creates the user under the specified account. If no account is specified, the username will be used as the account name.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// details for account used to store specific parameters
        /// </summary>
        public IDictionary<string, string> Details { get; set; }

        /// <summary>
        /// Account UUID, required for adding account from external provisioning system
        /// </summary>
        public string AccountUUID { get; set; }

        /// <summary>
        /// Creates the user under the specified domain.
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// Network domain for the account's networks
        /// </summary>
        public string NetworkDomain { get; set; }

        /// <summary>
        /// Specifies a timezone for this command. For more information on the timezone parameter, see Time Zone Format.
        /// </summary>
        public string Timezone { get; set; }

        /// <summary>
        /// User UUID, required for adding account from external provisioning system
        /// </summary>
        public string UserUUID { get; set; }

    }
    /// <summary>
    /// Creates an account from an LDAP user
    /// </summary>
    /// <summary>
    /// Creates an account from an LDAP user
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AccountResponse LdapCreateAccount(LdapCreateAccountRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AccountResponse LdapCreateAccount(LdapCreateAccountRequest request) => _proxy.Request<AccountResponse>(request);
    }
}
