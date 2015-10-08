using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteAlertsRequest : APIRequest
    {
        public DeleteAlertsRequest() : base("deleteAlerts") {}

        /// <summary>
        /// end date range to delete alerts (including) this date (use format "yyyy-MM-dd" or the new format "yyyy-MM-ddThh:mm:ss")
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// the IDs of the alerts
        /// </summary>
        public IList<long> Ids { get; set; }

        /// <summary>
        /// start date range to delete alerts (including) this date (use format "yyyy-MM-dd" or the new format "yyyy-MM-ddThh:mm:ss")
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// delete by alert type
        /// </summary>
        public string Type { get; set; }

    }
    /// <summary>
    /// Delete one or more alerts.
    /// </summary>
    /// <summary>
    /// Delete one or more alerts.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteAlerts(DeleteAlertsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteAlerts(DeleteAlertsRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
