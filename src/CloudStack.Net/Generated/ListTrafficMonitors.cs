using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListTrafficMonitorsRequest : APIRequest
    {
        public ListTrafficMonitorsRequest() : base("listTrafficMonitors") {}

        /// <summary>
        /// zone Id
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        public int? Page {
            get { return (int?) Parameters[nameof(Page).ToLower()]; }
            set { Parameters[nameof(Page).ToLower()] = value; }
        }

        public int? PageSize {
            get { return (int?) Parameters[nameof(PageSize).ToLower()]; }
            set { Parameters[nameof(PageSize).ToLower()] = value; }
        }

    }
    /// <summary>
    /// List traffic monitor Hosts.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<TrafficMonitorResponse> ListTrafficMonitors(ListTrafficMonitorsRequest request);
        Task<ListResponse<TrafficMonitorResponse>> ListTrafficMonitorsAsync(ListTrafficMonitorsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<TrafficMonitorResponse> ListTrafficMonitors(ListTrafficMonitorsRequest request) => _proxy.Request<ListResponse<TrafficMonitorResponse>>(request);
        public Task<ListResponse<TrafficMonitorResponse>> ListTrafficMonitorsAsync(ListTrafficMonitorsRequest request) => _proxy.RequestAsync<ListResponse<TrafficMonitorResponse>>(request);
    }
}
