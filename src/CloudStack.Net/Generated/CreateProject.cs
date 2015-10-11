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
        public string DisplayText {
            get { return (string) Parameters[nameof(DisplayText).ToLower()]; }
            set { Parameters[nameof(DisplayText).ToLower()] = value; }
        }

        /// <summary>
        /// name of the project
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// account who will be Admin for the project
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// domain ID of the account owning a project
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Creates a project
    /// </summary>
    /// <summary>
    /// Creates a project
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateProject(CreateProjectRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateProject(CreateProjectRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
