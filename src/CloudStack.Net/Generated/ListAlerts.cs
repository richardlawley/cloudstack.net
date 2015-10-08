using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListAlertsRequest : APIRequest
    {
        public ListAlertsRequest() : base("listAlerts") {}

        /// <summary>
        /// the ID of the alert
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// list by alert name
        /// </summary>
        public string Name { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// list by alert type
        /// </summary>
        public string Type { get; set; }

    }
    /// <summary>
    /// Lists all alerts.
    /// </summary>
    /// <summary>
    /// Lists all alerts.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<AlertResponse> ListAlerts(ListAlertsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<AlertResponse> ListAlerts(ListAlertsRequest request) => _proxy.Request<ListResponse<AlertResponse>>(request);
    }
}
