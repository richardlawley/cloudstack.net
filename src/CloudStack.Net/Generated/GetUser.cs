using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class GetUserRequest : APIRequest
    {
        public GetUserRequest() : base("getUser") {}

        /// <summary>
        /// API key of the user
        /// </summary>
        public string ApiKey { get; set; }

    }
    /// <summary>
    /// Find user account by API key
    /// </summary>
    /// <summary>
    /// Find user account by API key
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        UserResponse GetUser(GetUserRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public UserResponse GetUser(GetUserRequest request) => _proxy.Request<UserResponse>(request);
    }
}
