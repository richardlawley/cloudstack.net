using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class GetUserRequest : APIRequest
    {
        public GetUserRequest() : base("getUser") {}

        /// <summary>
        /// API key of the user
        /// </summary>
        public string Userapikey {
            get { return GetParameterValue<string>(nameof(Userapikey).ToLower()); }
            set { SetParameterValue(nameof(Userapikey).ToLower(), value); }
        }

    }
    /// <summary>
    /// Find user account by API key
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        UserResponse GetUser(GetUserRequest request);
        Task<UserResponse> GetUserAsync(GetUserRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public UserResponse GetUser(GetUserRequest request) => Proxy.Request<UserResponse>(request);
        public Task<UserResponse> GetUserAsync(GetUserRequest request) => Proxy.RequestAsync<UserResponse>(request);
    }
}
