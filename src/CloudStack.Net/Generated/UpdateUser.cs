using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateUserRequest : APIRequest
    {
        public UpdateUserRequest() : base("updateUser") {}

        /// <summary>
        /// User uuid
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// email
        /// </summary>
        public string Email {
            get { return (string) Parameters[nameof(Email).ToLower()]; }
            set { Parameters[nameof(Email).ToLower()] = value; }
        }

        /// <summary>
        /// first name
        /// </summary>
        public string Firstname {
            get { return (string) Parameters[nameof(Firstname).ToLower()]; }
            set { Parameters[nameof(Firstname).ToLower()] = value; }
        }

        /// <summary>
        /// last name
        /// </summary>
        public string Lastname {
            get { return (string) Parameters[nameof(Lastname).ToLower()]; }
            set { Parameters[nameof(Lastname).ToLower()] = value; }
        }

        /// <summary>
        /// Clear text password (default hashed to SHA256SALT). If you wish to use any other hasing algorithm, you would need to write a custom authentication adapter
        /// </summary>
        public string Password {
            get { return (string) Parameters[nameof(Password).ToLower()]; }
            set { Parameters[nameof(Password).ToLower()] = value; }
        }

        /// <summary>
        /// Specifies a timezone for this command. For more information on the timezone parameter, see Time Zone Format.
        /// </summary>
        public string Timezone {
            get { return (string) Parameters[nameof(Timezone).ToLower()]; }
            set { Parameters[nameof(Timezone).ToLower()] = value; }
        }

        /// <summary>
        /// The API key for the user. Must be specified with userSecretKey
        /// </summary>
        public string Userapikey {
            get { return (string) Parameters[nameof(Userapikey).ToLower()]; }
            set { Parameters[nameof(Userapikey).ToLower()] = value; }
        }

        /// <summary>
        /// Unique username
        /// </summary>
        public string Username {
            get { return (string) Parameters[nameof(Username).ToLower()]; }
            set { Parameters[nameof(Username).ToLower()] = value; }
        }

        /// <summary>
        /// The secret key for the user. Must be specified with userSecretKey
        /// </summary>
        public string Usersecretkey {
            get { return (string) Parameters[nameof(Usersecretkey).ToLower()]; }
            set { Parameters[nameof(Usersecretkey).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Updates a user account
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        UserResponse UpdateUser(UpdateUserRequest request);
        Task<UserResponse> UpdateUserAsync(UpdateUserRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public UserResponse UpdateUser(UpdateUserRequest request) => _proxy.Request<UserResponse>(request);
        public Task<UserResponse> UpdateUserAsync(UpdateUserRequest request) => _proxy.RequestAsync<UserResponse>(request);
    }
}
