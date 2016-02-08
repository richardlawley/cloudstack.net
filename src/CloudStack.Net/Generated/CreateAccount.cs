using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateAccountRequest : APIRequest
    {
        public CreateAccountRequest() : base("createAccount") {}

        /// <summary>
        /// Type of the account.  Specify 0 for user, 1 for root admin, and 2 for domain admin
        /// </summary>
        public short AccountType {
            get { return (short) Parameters[nameof(AccountType).ToLower()]; }
            set { Parameters[nameof(AccountType).ToLower()] = value; }
        }

        /// <summary>
        /// email
        /// </summary>
        public string Email {
            get { return (string) Parameters[nameof(Email).ToLower()]; }
            set { Parameters[nameof(Email).ToLower()] = value; }
        }

        /// <summary>
        /// firstname
        /// </summary>
        public string FirstName {
            get { return (string) Parameters[nameof(FirstName).ToLower()]; }
            set { Parameters[nameof(FirstName).ToLower()] = value; }
        }

        /// <summary>
        /// lastname
        /// </summary>
        public string LastName {
            get { return (string) Parameters[nameof(LastName).ToLower()]; }
            set { Parameters[nameof(LastName).ToLower()] = value; }
        }

        /// <summary>
        /// Clear text password (Default hashed to SHA256SALT). If you wish to use any other hashing algorithm, you would need to write a custom authentication adapter See Docs section.
        /// </summary>
        public string Password {
            get { return (string) Parameters[nameof(Password).ToLower()]; }
            set { Parameters[nameof(Password).ToLower()] = value; }
        }

        /// <summary>
        /// Unique username.
        /// </summary>
        public string UserName {
            get { return (string) Parameters[nameof(UserName).ToLower()]; }
            set { Parameters[nameof(UserName).ToLower()] = value; }
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
        public string TimeZone {
            get { return (string) Parameters[nameof(TimeZone).ToLower()]; }
            set { Parameters[nameof(TimeZone).ToLower()] = value; }
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
    /// Creates an account
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AccountResponse CreateAccount(CreateAccountRequest request);
        Task<AccountResponse> CreateAccountAsync(CreateAccountRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AccountResponse CreateAccount(CreateAccountRequest request) => _proxy.Request<AccountResponse>(request);
        public Task<AccountResponse> CreateAccountAsync(CreateAccountRequest request) => _proxy.RequestAsync<AccountResponse>(request);
    }
}
