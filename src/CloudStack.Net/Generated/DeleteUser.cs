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
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
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
        public SuccessResponse DeleteUser(DeleteUserRequest request) => _proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteUserAsync(DeleteUserRequest request) => _proxy.RequestAsync<SuccessResponse>(request);
    }
}
