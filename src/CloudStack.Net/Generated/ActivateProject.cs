using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ActivateProjectRequest : APIRequest
    {
        public ActivateProjectRequest() : base("activateProject") {}

        /// <summary>
        /// id of the project to be modified
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Activates a project
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ActivateProject(ActivateProjectRequest request);
        Task<AsyncJobResponse> ActivateProjectAsync(ActivateProjectRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ActivateProject(ActivateProjectRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> ActivateProjectAsync(ActivateProjectRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
