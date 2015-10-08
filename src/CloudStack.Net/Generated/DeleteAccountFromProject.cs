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
        public string AccountName { get; set; }

        /// <summary>
        /// ID of the project to remove the account from
        /// </summary>
        public Guid ProjectId { get; set; }

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
