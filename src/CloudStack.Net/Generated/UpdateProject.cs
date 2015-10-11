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
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// new Admin account for the project
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// display text of the project
        /// </summary>
        public string DisplayText {
            get { return (string) Parameters[nameof(DisplayText).ToLower()]; }
            set { Parameters[nameof(DisplayText).ToLower()] = value; }
        }

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
