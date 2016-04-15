using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Disables a user account
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DisableUser(DisableUserRequest request);
        Task<AsyncJobResponse> DisableUserAsync(DisableUserRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DisableUser(DisableUserRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DisableUserAsync(DisableUserRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
