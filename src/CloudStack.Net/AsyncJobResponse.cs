using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CloudStack.Net
{
    /// <summary>
    /// Response to an asynchronous API call.  This cannot be auto-generated as we don't know at compile time what the
    /// JobResult parameter will be.
    /// </summary>
    public class AsyncJobResponse
    {
        /// <summary>
        /// the account that executed the async command
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// the async command executed
        /// </summary>
        public string Cmd { get; set; }

        /// <summary>
        ///   the created date of the job
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// the unique ID of the instance/entity object related to the job
        /// </summary>
        public string JobInstanceId { get; set; }

        /// <summary>
        /// the instance/entity object related to the job
        /// </summary>
        public string JobInstanceType { get; set; }

        /// <summary>
        /// the progress information of the PENDING job
        /// </summary>
        public int JobProcStatus { get; set; }

        /// <summary>
        /// the result reason
        /// </summary>
        public JObject JobResult { get; set; }

        /// <summary>
        /// the result code for the job
        /// </summary>
        public int JobResultCode { get; set; }

        /// <summary>
        /// the result type
        /// </summary>
        public string JobResultType { get; set; }

        /// <summary>
        /// the current job status-should be 0 for PENDING
        /// </summary>
        public int JobStatus { get; set; }

        /// <summary>
        /// the user that executed the async command
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// the ID of the async job
        /// </summary>
        public Guid jobid { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);

        public T DecodeJobResult<T>() => JobResult.ToObject<T>();
    }
}