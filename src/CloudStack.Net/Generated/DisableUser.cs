using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DisableUserRequest : APIRequest
    {
        public DisableUserRequest() : base("disableUser") {}

        /// <summary>
        /// Disables user by user ID.
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Disables a user account
    /// </summary>
    /// <summary>
    /// Disables a user account
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        UserResponse DisableUser(DisableUserRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public UserResponse DisableUser(DisableUserRequest request) => _proxy.Request<UserResponse>(request);
    }
}
