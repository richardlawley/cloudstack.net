using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateAccountRequest : APIRequest
    {
        public CreateAccountRequest() : base("createAccount") {}

        /// <summary>
        /// Type of the account.  Specify 0 for user, 1 for root admin, and 2 for domain admin
        /// </summary>
        public short AccountType { get; set; }

        /// <summary>
        /// email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// firstname
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// lastname
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Clear text password (Default hashed to SHA256SALT). If you wish to use any other hashing algorithm, you would need to write a custom authentication adapter See Docs section.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Unique username.
        /// </summary>
        public string UserName { get; set; }

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
        public string TimeZone { get; set; }

        /// <summary>
        /// User UUID, required for adding account from external provisioning system
        /// </summary>
        public string UserUUID { get; set; }

    }
    /// <summary>
    /// Creates an account
    /// </summary>
    /// <summary>
    /// Creates an account
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AccountResponse CreateAccount(CreateAccountRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AccountResponse CreateAccount(CreateAccountRequest request) => _proxy.Request<AccountResponse>(request);
    }
}
