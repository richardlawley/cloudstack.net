using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListAsyncJobsRequest : APIListRequest
    {
        public ListAsyncJobsRequest() : base("listAsyncJobs") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId {
            get { return GetParameterValue<Guid>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// defaults to false, but if true, lists all resources from the parent specified by the domainId till leaves.
        /// </summary>
        public bool? Isrecursive {
            get { return GetParameterValue<bool?>(nameof(Isrecursive).ToLower()); }
            set { SetParameterValue(nameof(Isrecursive).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// If set to false, list only resources belonging to the command's caller; if set to true - list resources that the caller is authorized to see. Default value is false
        /// </summary>
        public bool? ListAll {
            get { return GetParameterValue<bool?>(nameof(ListAll).ToLower()); }
            set { SetParameterValue(nameof(ListAll).ToLower(), value); }
        }

        /// <summary>
        /// the start date of the async job
        /// </summary>
        public DateTimeOffset? StartDate {
            get { return GetParameterValue<DateTimeOffset?>(nameof(StartDate).ToLower()); }
            set { SetParameterValue(nameof(StartDate).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists all pending asynchronous jobs for the account.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<AsyncJobResponse> ListAsyncJobs(ListAsyncJobsRequest request);
        Task<ListResponse<AsyncJobResponse>> ListAsyncJobsAsync(ListAsyncJobsRequest request);
        ListResponse<AsyncJobResponse> ListAsyncJobsAllPages(ListAsyncJobsRequest request);
        Task<ListResponse<AsyncJobResponse>> ListAsyncJobsAllPagesAsync(ListAsyncJobsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<AsyncJobResponse> ListAsyncJobs(ListAsyncJobsRequest request) => _proxy.Request<ListResponse<AsyncJobResponse>>(request);
        public Task<ListResponse<AsyncJobResponse>> ListAsyncJobsAsync(ListAsyncJobsRequest request) => _proxy.RequestAsync<ListResponse<AsyncJobResponse>>(request);
        public ListResponse<AsyncJobResponse> ListAsyncJobsAllPages(ListAsyncJobsRequest request) => _proxy.RequestAllPages<AsyncJobResponse>(request);
        public Task<ListResponse<AsyncJobResponse>> ListAsyncJobsAllPagesAsync(ListAsyncJobsRequest request) => _proxy.RequestAllPagesAsync<AsyncJobResponse>(request);
    }
}
