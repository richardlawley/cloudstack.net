using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateUserRequest : APIRequest
    {
        public UpdateUserRequest() : base("updateUser") {}

        /// <summary>
        /// User uuid
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// first name
        /// </summary>
        public string Firstname { get; set; }

        /// <summary>
        /// last name
        /// </summary>
        public string Lastname { get; set; }

        /// <summary>
        /// Clear text password (default hashed to SHA256SALT). If you wish to use any other hasing algorithm, you would need to write a custom authentication adapter
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Specifies a timezone for this command. For more information on the timezone parameter, see Time Zone Format.
        /// </summary>
        public string Timezone { get; set; }

        /// <summary>
        /// The API key for the user. Must be specified with userSecretKey
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Unique username
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// The secret key for the user. Must be specified with userSecretKey
        /// </summary>
        public string SecretKey { get; set; }

    }
    /// <summary>
    /// Updates a user account
    /// </summary>
    /// <summary>
    /// Updates a user account
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        UserResponse UpdateUser(UpdateUserRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public UserResponse UpdateUser(UpdateUserRequest request) => _proxy.Request<UserResponse>(request);
    }
}
