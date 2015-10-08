using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ArchiveAlertsRequest : APIRequest
    {
        public ArchiveAlertsRequest() : base("archiveAlerts") {}

        /// <summary>
        /// end date range to archive alerts (including) this date (use format "yyyy-MM-dd" or the new format "yyyy-MM-ddThh:mm:ss")
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// the IDs of the alerts
        /// </summary>
        public IList<long> Ids { get; set; }

        /// <summary>
        /// start date range to archive alerts (including) this date (use format "yyyy-MM-dd" or the new format "yyyy-MM-ddThh:mm:ss")
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// archive by alert type
        /// </summary>
        public string Type { get; set; }

    }
    /// <summary>
    /// Archive one or more alerts.
    /// </summary>
    /// <summary>
    /// Archive one or more alerts.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse ArchiveAlerts(ArchiveAlertsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse ArchiveAlerts(ArchiveAlertsRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
