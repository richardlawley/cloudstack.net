using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteAccountFromProjectRequest : APIRequest
    {
        public DeleteAccountFromProjectRequest() : base("deleteAccountFromProject") {}

        /// <summary>
        /// name of the account to be removed from the project
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// ID of the project to remove the account from
        /// </summary>
        public Guid ProjectId {
            get { return GetParameterValue<Guid>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes account from the project
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteAccountFromProject(DeleteAccountFromProjectRequest request);
        Task<AsyncJobResponse> DeleteAccountFromProjectAsync(DeleteAccountFromProjectRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteAccountFromProject(DeleteAccountFromProjectRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteAccountFromProjectAsync(DeleteAccountFromProjectRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
