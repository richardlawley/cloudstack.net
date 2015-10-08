using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateProjectRequest : APIRequest
    {
        public CreateProjectRequest() : base("createProject") {}

        /// <summary>
        /// display text of the project
        /// </summary>
        public string DisplayText { get; set; }

        /// <summary>
        /// name of the project
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// account who will be Admin for the project
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// domain ID of the account owning a project
        /// </summary>
        public Guid DomainId { get; set; }

    }
    /// <summary>
    /// Creates a project
    /// </summary>
    /// <summary>
    /// Creates a project
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ProjectResponse CreateProject(CreateProjectRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ProjectResponse CreateProject(CreateProjectRequest request) => _proxy.Request<ProjectResponse>(request);
    }
}
