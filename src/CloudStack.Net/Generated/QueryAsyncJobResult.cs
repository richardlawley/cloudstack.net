using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (Guid) Parameters[nameof(Jobid).ToLower()]; }
            set { Parameters[nameof(Jobid).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Retrieves the current status of asynchronous job.
    /// </summary>
    /// <summary>
    /// Retrieves the current status of asynchronous job.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse QueryAsyncJobResult(QueryAsyncJobResultRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse QueryAsyncJobResult(QueryAsyncJobResultRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
