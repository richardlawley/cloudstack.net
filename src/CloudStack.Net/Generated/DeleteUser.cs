using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteUserRequest : APIRequest
    {
        public DeleteUserRequest() : base("deleteUser") {}

        /// <summary>
        /// id of the user to be deleted
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Deletes a user for an account
    /// </summary>
    /// <summary>
    /// Deletes a user for an account
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteUser(DeleteUserRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteUser(DeleteUserRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
