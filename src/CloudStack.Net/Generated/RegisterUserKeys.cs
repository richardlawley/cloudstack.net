using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RegisterUserKeysRequest : APIRequest
    {
        public RegisterUserKeysRequest() : base("registerUserKeys") {}

        /// <summary>
        /// User id
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// This command allows a user to register for the developer API, returning a secret key and an API key. This request is made through the integration API port, so it is a privileged command and must be made on behalf of a user. It is up to the implementer just how the username and password are entered, and then how that translates to an integration API request. Both secret key and API key should be returned to the user
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        RegisterResponse RegisterUserKeys(RegisterUserKeysRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public RegisterResponse RegisterUserKeys(RegisterUserKeysRequest request) => _proxy.Request<RegisterResponse>(request);
    }
}
