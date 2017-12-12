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
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
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
        public AsyncJobResponse DeleteAccount(DeleteAccountRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteAccountAsync(DeleteAccountRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
