using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteAccountFromProjectRequest : APIRequest
    {
        public DeleteAccountFromProjectRequest() : base("deleteAccountFromProject") {}

        /// <summary>
        /// name of the account to be removed from the project
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// id of the project to remove the account from
        /// </summary>
        public Guid ProjectId {
            get { return (Guid) Parameters[nameof(ProjectId).ToLower()]; }
            set { Parameters[nameof(ProjectId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Deletes account from the project
    /// </summary>
    /// <summary>
    /// Deletes account from the project
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteAccountFromProject(DeleteAccountFromProjectRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteAccountFromProject(DeleteAccountFromProjectRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
