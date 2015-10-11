using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Activates a project
    /// </summary>
    /// <summary>
    /// Activates a project
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ProjectResponse ActivateProject(ActivateProjectRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ProjectResponse ActivateProject(ActivateProjectRequest request) => _proxy.Request<ProjectResponse>(request);
    }
}
