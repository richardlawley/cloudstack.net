using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListTrafficMonitorsRequest : APIListRequest
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

    }
    /// <summary>
    /// List traffic monitor Hosts.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<TrafficMonitorResponse> ListTrafficMonitors(ListTrafficMonitorsRequest request);
        Task<ListResponse<TrafficMonitorResponse>> ListTrafficMonitorsAsync(ListTrafficMonitorsRequest request);
        ListResponse<TrafficMonitorResponse> ListTrafficMonitorsAllPages(ListTrafficMonitorsRequest request);
        Task<ListResponse<TrafficMonitorResponse>> ListTrafficMonitorsAllPagesAsync(ListTrafficMonitorsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<TrafficMonitorResponse> ListTrafficMonitors(ListTrafficMonitorsRequest request) => _proxy.Request<ListResponse<TrafficMonitorResponse>>(request);
        public Task<ListResponse<TrafficMonitorResponse>> ListTrafficMonitorsAsync(ListTrafficMonitorsRequest request) => _proxy.RequestAsync<ListResponse<TrafficMonitorResponse>>(request);
        public ListResponse<TrafficMonitorResponse> ListTrafficMonitorsAllPages(ListTrafficMonitorsRequest request) => _proxy.RequestAllPages<TrafficMonitorResponse>(request);
        public Task<ListResponse<TrafficMonitorResponse>> ListTrafficMonitorsAllPagesAsync(ListTrafficMonitorsRequest request) => _proxy.RequestAllPagesAsync<TrafficMonitorResponse>(request);
    }
}
