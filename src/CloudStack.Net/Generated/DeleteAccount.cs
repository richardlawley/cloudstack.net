using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteAccountRequest : APIRequest
    {
        public DeleteAccountRequest() : base("deleteAccount") {}

        /// <summary>
        /// Account id
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Deletes a account, and all users associated with this account
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteAccount(DeleteAccountRequest request);
        Task<AsyncJobResponse> DeleteAccountAsync(DeleteAccountRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteAccount(DeleteAccountRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteAccountAsync(DeleteAccountRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
