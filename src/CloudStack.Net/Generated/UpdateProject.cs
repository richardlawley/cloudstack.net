using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateProjectRequest : APIRequest
    {
        public UpdateProjectRequest() : base("updateProject") {}

        /// <summary>
        /// id of the project to be modified
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// new Admin account for the project
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// display text of the project
        /// </summary>
        public string DisplayText {
            get { return GetParameterValue<string>(nameof(DisplayText).ToLower()); }
            set { SetParameterValue(nameof(DisplayText).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates a project
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdateProject(UpdateProjectRequest request);
        Task<AsyncJobResponse> UpdateProjectAsync(UpdateProjectRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdateProject(UpdateProjectRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> UpdateProjectAsync(UpdateProjectRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
