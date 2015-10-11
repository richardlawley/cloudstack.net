using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateUserRequest : APIRequest
    {
        public CreateUserRequest() : base("createUser") {}

        /// <summary>
        /// Creates the user under the specified account. If no account is specified, the username will be used as the account name.
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
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
        public string Firstname {
            get { return (string) Parameters[nameof(Firstname).ToLower()]; }
            set { Parameters[nameof(Firstname).ToLower()] = value; }
        }

        /// <summary>
        /// lastname
        /// </summary>
        public string Lastname {
            get { return (string) Parameters[nameof(Lastname).ToLower()]; }
            set { Parameters[nameof(Lastname).ToLower()] = value; }
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
        public string Username {
            get { return (string) Parameters[nameof(Username).ToLower()]; }
            set { Parameters[nameof(Username).ToLower()] = value; }
        }

        /// <summary>
        /// Creates the user under the specified domain. Has to be accompanied with the account parameter
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
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
    /// Creates a user for an account that already exists
    /// </summary>
    /// <summary>
    /// Creates a user for an account that already exists
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        UserResponse CreateUser(CreateUserRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public UserResponse CreateUser(CreateUserRequest request) => _proxy.Request<UserResponse>(request);
    }
}
