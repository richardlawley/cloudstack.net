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
        /// ID of the project to add the account to
        /// </summary>
        public Guid ProjectId { get; set; }

        /// <summary>
        /// name of the account to be added to the project
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// email to which invitation to the project is going to be sent
        /// </summary>
        public string Email { get; set; }

    }
    /// <summary>
    /// Adds account to a project
    /// </summary>
    /// <summary>
    /// Adds account to a project
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
