using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteUserRequest : APIRequest
    {
        public DeleteUserRequest() : base("deleteUser") {}

        /// <summary>
        /// id of the user to be deleted
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a user for an account
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteUser(DeleteUserRequest request);
        Task<SuccessResponse> DeleteUserAsync(DeleteUserRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteUser(DeleteUserRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteUserAsync(DeleteUserRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
