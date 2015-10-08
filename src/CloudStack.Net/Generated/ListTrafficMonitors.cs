using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListTrafficMonitorsRequest : APIRequest
    {
        public ListTrafficMonitorsRequest() : base("listTrafficMonitors") {}

        /// <summary>
        /// zone Id
        /// </summary>
        public Guid ZoneId { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

    }
    /// <summary>
    /// List traffic monitor Hosts.
    /// </summary>
    /// <summary>
    /// List traffic monitor Hosts.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<TrafficMonitorResponse> ListTrafficMonitors(ListTrafficMonitorsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<TrafficMonitorResponse> ListTrafficMonitors(ListTrafficMonitorsRequest request) => _proxy.Request<ListResponse<TrafficMonitorResponse>>(request);
    }
}
