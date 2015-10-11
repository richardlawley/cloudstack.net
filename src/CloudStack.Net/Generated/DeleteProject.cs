using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Deletes a project
    /// </summary>
    /// <summary>
    /// Deletes a project
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteProject(DeleteProjectRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteProject(DeleteProjectRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
