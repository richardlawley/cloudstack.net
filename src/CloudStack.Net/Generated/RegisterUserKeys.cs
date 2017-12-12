using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// This command allows a user to register for the developer API, returning a secret key and an API key. This request is made through the integration API port, so it is a privileged command and must be made on behalf of a user. It is up to the implementer just how the username and password are entered, and then how that translates to an integration API request. Both secret key and API key should be returned to the user
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        RegisterResponse RegisterUserKeys(RegisterUserKeysRequest request);
        Task<RegisterResponse> RegisterUserKeysAsync(RegisterUserKeysRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public RegisterResponse RegisterUserKeys(RegisterUserKeysRequest request) => Proxy.Request<RegisterResponse>(request);
        public Task<RegisterResponse> RegisterUserKeysAsync(RegisterUserKeysRequest request) => Proxy.RequestAsync<RegisterResponse>(request);
    }
}
