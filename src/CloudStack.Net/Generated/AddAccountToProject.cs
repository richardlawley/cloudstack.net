using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddAccountToProjectRequest : APIRequest
    {
        public AddAccountToProjectRequest() : base("addAccountToProject") {}

        /// <summary>
        /// id of the project to add the account to
        /// </summary>
        public Guid ProjectId {
            get { return (Guid) Parameters[nameof(ProjectId).ToLower()]; }
            set { Parameters[nameof(ProjectId).ToLower()] = value; }
        }

        /// <summary>
        /// name of the account to be added to the project
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// email to which invitation to the project is going to be sent
        /// </summary>
        public string Email {
            get { return (string) Parameters[nameof(Email).ToLower()]; }
            set { Parameters[nameof(Email).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Adds acoount to a project
    /// </summary>
    /// <summary>
    /// Adds acoount to a project
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse AddAccountToProject(AddAccountToProjectRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse AddAccountToProject(AddAccountToProjectRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
