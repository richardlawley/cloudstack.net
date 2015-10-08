using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListProjectAccountsRequest : APIRequest
    {
        public ListProjectAccountsRequest() : base("listProjectAccounts") {}

        /// <summary>
        /// ID of the project
        /// </summary>
        public Guid ProjectId { get; set; }

        /// <summary>
        /// list accounts of the project by account name
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// list accounts of the project by role
        /// </summary>
        public string Role { get; set; }

    }
    /// <summary>
    /// Lists project's accounts
    /// </summary>
    /// <summary>
    /// Lists project's accounts
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ProjectResponse> ListProjectAccounts(ListProjectAccountsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ProjectResponse> ListProjectAccounts(ListProjectAccountsRequest request) => _proxy.Request<ListResponse<ProjectResponse>>(request);
    }
}
