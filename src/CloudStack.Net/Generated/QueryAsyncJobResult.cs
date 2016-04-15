using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class QueryAsyncJobResultRequest : APIRequest
    {
        public QueryAsyncJobResultRequest() : base("queryAsyncJobResult") {}

        /// <summary>
        /// the ID of the asychronous job
        /// </summary>
        public Guid Jobid {
            get { return GetParameterValue<Guid>(nameof(Jobid).ToLower()); }
            set { SetParameterValue(nameof(Jobid).ToLower(), value); }
        }

    }
    /// <summary>
    /// Retrieves the current status of asynchronous job.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse QueryAsyncJobResult(QueryAsyncJobResultRequest request);
        Task<AsyncJobResponse> QueryAsyncJobResultAsync(QueryAsyncJobResultRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse QueryAsyncJobResult(QueryAsyncJobResultRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> QueryAsyncJobResultAsync(QueryAsyncJobResultRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
