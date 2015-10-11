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

        public int? Page {
            get { return (int?) Parameters[nameof(Page).ToLower()]; }
            set { Parameters[nameof(Page).ToLower()] = value; }
        }

        public int? PageSize {
            get { return (int?) Parameters[nameof(PageSize).ToLower()]; }
            set { Parameters[nameof(PageSize).ToLower()] = value; }
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
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<CounterResponse> ListCounters(ListCountersRequest request) => _proxy.Request<ListResponse<CounterResponse>>(request);
    }
}
