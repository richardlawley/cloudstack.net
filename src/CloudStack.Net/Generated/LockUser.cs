using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class LockUserRequest : APIRequest
    {
        public LockUserRequest() : base("lockUser") {}

        /// <summary>
        /// Locks user by user ID.
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Locks a user account
    /// </summary>
    /// <summary>
    /// Locks a user account
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        UserResponse LockUser(LockUserRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public UserResponse LockUser(LockUserRequest request) => _proxy.Request<UserResponse>(request);
    }
}
