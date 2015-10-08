using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListCountersRequest : APIRequest
    {
        public ListCountersRequest() : base("listCounters") {}

        /// <summary>
        /// ID of the Counter.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// Name of the counter.
        /// </summary>
        public string Name { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// Source of the counter.
        /// </summary>
        public string Source { get; set; }

    }
    /// <summary>
    /// List the counters
    /// </summary>
    /// <summary>
    /// List the counters
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<CounterResponse> ListCounters(ListCountersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<CounterResponse> ListCounters(ListCountersRequest request) => _proxy.Request<ListResponse<CounterResponse>>(request);
    }
}
