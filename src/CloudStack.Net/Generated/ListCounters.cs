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
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// Name of the counter.
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// Source of the counter.
        /// </summary>
        public string Source {
            get { return GetParameterValue<string>(nameof(Source).ToLower()); }
            set { SetParameterValue(nameof(Source).ToLower(), value); }
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
        public ListResponse<CounterResponse> ListCounters(ListCountersRequest request) => Proxy.Request<ListResponse<CounterResponse>>(request);
        public Task<ListResponse<CounterResponse>> ListCountersAsync(ListCountersRequest request) => Proxy.RequestAsync<ListResponse<CounterResponse>>(request);
        public ListResponse<CounterResponse> ListCountersAllPages(ListCountersRequest request) => Proxy.RequestAllPages<CounterResponse>(request);
        public Task<ListResponse<CounterResponse>> ListCountersAllPagesAsync(ListCountersRequest request) => Proxy.RequestAllPagesAsync<CounterResponse>(request);
    }
}
