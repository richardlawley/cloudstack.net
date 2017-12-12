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
            get { return GetParameterValue<Guid>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// list accounts of the project by account name
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// list accounts of the project by role
        /// </summary>
        public string Role {
            get { return GetParameterValue<string>(nameof(Role).ToLower()); }
            set { SetParameterValue(nameof(Role).ToLower(), value); }
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
        public ListResponse<ProjectResponse> ListProjectAccounts(ListProjectAccountsRequest request) => Proxy.Request<ListResponse<ProjectResponse>>(request);
        public Task<ListResponse<ProjectResponse>> ListProjectAccountsAsync(ListProjectAccountsRequest request) => Proxy.RequestAsync<ListResponse<ProjectResponse>>(request);
        public ListResponse<ProjectResponse> ListProjectAccountsAllPages(ListProjectAccountsRequest request) => Proxy.RequestAllPages<ProjectResponse>(request);
        public Task<ListResponse<ProjectResponse>> ListProjectAccountsAllPagesAsync(ListProjectAccountsRequest request) => Proxy.RequestAllPagesAsync<ProjectResponse>(request);
    }
}
