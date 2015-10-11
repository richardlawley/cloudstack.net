using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class SuspendProjectRequest : APIRequest
    {
        public SuspendProjectRequest() : base("suspendProject") {}

        /// <summary>
        /// id of the project to be suspended
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Suspends a project
    /// </summary>
    /// <summary>
    /// Suspends a project
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse SuspendProject(SuspendProjectRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse SuspendProject(SuspendProjectRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
