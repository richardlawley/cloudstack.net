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
        public string AccountName { get; set; }

        /// <summary>
        /// email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// firstname
        /// </summary>
        public string Firstname { get; set; }

        /// <summary>
        /// lastname
        /// </summary>
        public string Lastname { get; set; }

        /// <summary>
        /// Clear text password (Default hashed to SHA256SALT). If you wish to use any other hashing algorithm, you would need to write a custom authentication adapter See Docs section.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Unique username.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Creates the user under the specified domain. Has to be accompanied with the account parameter
        /// </summary>
        public Guid DomainId { get; set; }

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
