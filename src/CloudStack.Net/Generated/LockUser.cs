using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Locks a user account
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        UserResponse LockUser(LockUserRequest request);
        Task<UserResponse> LockUserAsync(LockUserRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public UserResponse LockUser(LockUserRequest request) => Proxy.Request<UserResponse>(request);
        public Task<UserResponse> LockUserAsync(LockUserRequest request) => Proxy.RequestAsync<UserResponse>(request);
    }
}
