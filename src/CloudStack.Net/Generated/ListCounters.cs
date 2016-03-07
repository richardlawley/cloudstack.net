using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListCountersRequest : APIListRequest
    {
        public ListCountersRequest() : base("listCounters") {}

        /// <summary>
        /// ID of the Counter.
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        /// <summary>
        /// Name of the counter.
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// Source of the counter.
        /// </summary>
        public string Source {
            get { return (string) Parameters[nameof(Source).ToLower()]; }
            set { Parameters[nameof(Source).ToLower()] = value; }
        }

    }
    /// <summary>
    /// List the counters
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<CounterResponse> ListCounters(ListCountersRequest request);
        Task<ListResponse<CounterResponse>> ListCountersAsync(ListCountersRequest request);
        ListResponse<CounterResponse> ListCountersAllPages(ListCountersRequest request);
        Task<ListResponse<CounterResponse>> ListCountersAllPagesAsync(ListCountersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<CounterResponse> ListCounters(ListCountersRequest request) => _proxy.Request<ListResponse<CounterResponse>>(request);
        public Task<ListResponse<CounterResponse>> ListCountersAsync(ListCountersRequest request) => _proxy.RequestAsync<ListResponse<CounterResponse>>(request);
        public ListResponse<CounterResponse> ListCountersAllPages(ListCountersRequest request) => _proxy.RequestAllPages<CounterResponse>(request);
        public Task<ListResponse<CounterResponse>> ListCountersAllPagesAsync(ListCountersRequest request) => _proxy.RequestAllPagesAsync<CounterResponse>(request);
    }
}
