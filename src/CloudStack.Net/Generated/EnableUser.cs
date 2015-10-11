using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class EnableUserRequest : APIRequest
    {
        public EnableUserRequest() : base("enableUser") {}

        /// <summary>
        /// Enables user by user ID.
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Enables a user account
    /// </summary>
    /// <summary>
    /// Enables a user account
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        UserResponse EnableUser(EnableUserRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public UserResponse EnableUser(EnableUserRequest request) => _proxy.Request<UserResponse>(request);
    }
}
