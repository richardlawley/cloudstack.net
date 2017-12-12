using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddAccountToProjectRequest : APIRequest
    {
        public AddAccountToProjectRequest() : base("addAccountToProject") {}

        /// <summary>
        /// ID of the project to add the account to
        /// </summary>
        public Guid ProjectId {
            get { return GetParameterValue<Guid>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// name of the account to be added to the project
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// email to which invitation to the project is going to be sent
        /// </summary>
        public string Email {
            get { return GetParameterValue<string>(nameof(Email).ToLower()); }
            set { SetParameterValue(nameof(Email).ToLower(), value); }
        }

    }
    /// <summary>
    /// Adds account to a project
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AddAccountToProject(AddAccountToProjectRequest request);
        Task<AsyncJobResponse> AddAccountToProjectAsync(AddAccountToProjectRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AddAccountToProject(AddAccountToProjectRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> AddAccountToProjectAsync(AddAccountToProjectRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
