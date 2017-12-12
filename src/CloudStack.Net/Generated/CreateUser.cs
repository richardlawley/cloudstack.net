using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// email
        /// </summary>
        public string Email {
            get { return GetParameterValue<string>(nameof(Email).ToLower()); }
            set { SetParameterValue(nameof(Email).ToLower(), value); }
        }

        /// <summary>
        /// firstname
        /// </summary>
        public string Firstname {
            get { return GetParameterValue<string>(nameof(Firstname).ToLower()); }
            set { SetParameterValue(nameof(Firstname).ToLower(), value); }
        }

        /// <summary>
        /// lastname
        /// </summary>
        public string Lastname {
            get { return GetParameterValue<string>(nameof(Lastname).ToLower()); }
            set { SetParameterValue(nameof(Lastname).ToLower(), value); }
        }

        /// <summary>
        /// Clear text password (Default hashed to SHA256SALT). If you wish to use any other hashing algorithm, you would need to write a custom authentication adapter See Docs section.
        /// </summary>
        public string Password {
            get { return GetParameterValue<string>(nameof(Password).ToLower()); }
            set { SetParameterValue(nameof(Password).ToLower(), value); }
        }

        /// <summary>
        /// Unique username.
        /// </summary>
        public string Username {
            get { return GetParameterValue<string>(nameof(Username).ToLower()); }
            set { SetParameterValue(nameof(Username).ToLower(), value); }
        }

        /// <summary>
        /// Creates the user under the specified domain. Has to be accompanied with the account parameter
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
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
    /// Creates a user for an account that already exists
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        UserResponse CreateUser(CreateUserRequest request);
        Task<UserResponse> CreateUserAsync(CreateUserRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public UserResponse CreateUser(CreateUserRequest request) => Proxy.Request<UserResponse>(request);
        public Task<UserResponse> CreateUserAsync(CreateUserRequest request) => Proxy.RequestAsync<UserResponse>(request);
    }
}
