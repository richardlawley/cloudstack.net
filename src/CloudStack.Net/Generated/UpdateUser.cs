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
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// email
        /// </summary>
        public string Email {
            get { return GetParameterValue<string>(nameof(Email).ToLower()); }
            set { SetParameterValue(nameof(Email).ToLower(), value); }
        }

        /// <summary>
        /// first name
        /// </summary>
        public string Firstname {
            get { return GetParameterValue<string>(nameof(Firstname).ToLower()); }
            set { SetParameterValue(nameof(Firstname).ToLower(), value); }
        }

        /// <summary>
        /// last name
        /// </summary>
        public string Lastname {
            get { return GetParameterValue<string>(nameof(Lastname).ToLower()); }
            set { SetParameterValue(nameof(Lastname).ToLower(), value); }
        }

        /// <summary>
        /// Clear text password (default hashed to SHA256SALT). If you wish to use any other hasing algorithm, you would need to write a custom authentication adapter
        /// </summary>
        public string Password {
            get { return GetParameterValue<string>(nameof(Password).ToLower()); }
            set { SetParameterValue(nameof(Password).ToLower(), value); }
        }

        /// <summary>
        /// Specifies a timezone for this command. For more information on the timezone parameter, see Time Zone Format.
        /// </summary>
        public string Timezone {
            get { return GetParameterValue<string>(nameof(Timezone).ToLower()); }
            set { SetParameterValue(nameof(Timezone).ToLower(), value); }
        }

        /// <summary>
        /// The API key for the user. Must be specified with userSecretKey
        /// </summary>
        public string Userapikey {
            get { return GetParameterValue<string>(nameof(Userapikey).ToLower()); }
            set { SetParameterValue(nameof(Userapikey).ToLower(), value); }
        }

        /// <summary>
        /// Unique username
        /// </summary>
        public string Username {
            get { return GetParameterValue<string>(nameof(Username).ToLower()); }
            set { SetParameterValue(nameof(Username).ToLower(), value); }
        }

        /// <summary>
        /// The secret key for the user. Must be specified with userSecretKey
        /// </summary>
        public string Usersecretkey {
            get { return GetParameterValue<string>(nameof(Usersecretkey).ToLower()); }
            set { SetParameterValue(nameof(Usersecretkey).ToLower(), value); }
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
        public UserResponse UpdateUser(UpdateUserRequest request) => Proxy.Request<UserResponse>(request);
        public Task<UserResponse> UpdateUserAsync(UpdateUserRequest request) => Proxy.RequestAsync<UserResponse>(request);
    }
}
