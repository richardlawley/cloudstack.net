using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteProjectRequest : APIRequest
    {
        public DeleteProjectRequest() : base("deleteProject") {}

        /// <summary>
        /// id of the project to be deleted
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a project
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteProject(DeleteProjectRequest request);
        Task<AsyncJobResponse> DeleteProjectAsync(DeleteProjectRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteProject(DeleteProjectRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteProjectAsync(DeleteProjectRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
