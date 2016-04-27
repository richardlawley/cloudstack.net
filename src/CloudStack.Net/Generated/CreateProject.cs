using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<string>(nameof(DisplayText).ToLower()); }
            set { SetParameterValue(nameof(DisplayText).ToLower(), value); }
        }

        /// <summary>
        /// name of the project
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// account who will be Admin for the project
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// domain ID of the account owning a project
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates a project
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateProject(CreateProjectRequest request);
        Task<AsyncJobResponse> CreateProjectAsync(CreateProjectRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateProject(CreateProjectRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateProjectAsync(CreateProjectRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
