using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateProjectRequest : APIRequest
    {
        public UpdateProjectRequest() : base("updateProject") {}

        /// <summary>
        /// id of the project to be modified
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// new Admin account for the project
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// display text of the project
        /// </summary>
        public string DisplayText { get; set; }

    }
    /// <summary>
    /// Updates a project
    /// </summary>
    /// <summary>
    /// Updates a project
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ProjectResponse UpdateProject(UpdateProjectRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ProjectResponse UpdateProject(UpdateProjectRequest request) => _proxy.Request<ProjectResponse>(request);
    }
}
