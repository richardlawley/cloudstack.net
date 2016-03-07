using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListProjectAccountsRequest : APIListRequest
    {
        public ListProjectAccountsRequest() : base("listProjectAccounts") {}

        /// <summary>
        /// ID of the project
        /// </summary>
        public Guid ProjectId {
            get { return (Guid) Parameters[nameof(ProjectId).ToLower()]; }
            set { Parameters[nameof(ProjectId).ToLower()] = value; }
        }

        /// <summary>
        /// list accounts of the project by account name
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        /// <summary>
        /// list accounts of the project by role
        /// </summary>
        public string Role {
            get { return (string) Parameters[nameof(Role).ToLower()]; }
            set { Parameters[nameof(Role).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists project's accounts
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ProjectResponse> ListProjectAccounts(ListProjectAccountsRequest request);
        Task<ListResponse<ProjectResponse>> ListProjectAccountsAsync(ListProjectAccountsRequest request);
        ListResponse<ProjectResponse> ListProjectAccountsAllPages(ListProjectAccountsRequest request);
        Task<ListResponse<ProjectResponse>> ListProjectAccountsAllPagesAsync(ListProjectAccountsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ProjectResponse> ListProjectAccounts(ListProjectAccountsRequest request) => _proxy.Request<ListResponse<ProjectResponse>>(request);
        public Task<ListResponse<ProjectResponse>> ListProjectAccountsAsync(ListProjectAccountsRequest request) => _proxy.RequestAsync<ListResponse<ProjectResponse>>(request);
        public ListResponse<ProjectResponse> ListProjectAccountsAllPages(ListProjectAccountsRequest request) => _proxy.RequestAllPages<ProjectResponse>(request);
        public Task<ListResponse<ProjectResponse>> ListProjectAccountsAllPagesAsync(ListProjectAccountsRequest request) => _proxy.RequestAllPagesAsync<ProjectResponse>(request);
    }
}
