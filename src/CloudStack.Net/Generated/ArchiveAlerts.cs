using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ArchiveAlertsRequest : APIRequest
    {
        public ArchiveAlertsRequest() : base("archiveAlerts") {}

        /// <summary>
        /// end date range to archive alerts (including) this date (use format "yyyy-MM-dd" or the new format "yyyy-MM-ddThh:mm:ss")
        /// </summary>
        public DateTime? EndDate {
            get { return GetParameterValue<DateTime?>(nameof(EndDate).ToLower()); }
            set { SetParameterValue(nameof(EndDate).ToLower(), value); }
        }

        /// <summary>
        /// the IDs of the alerts
        /// </summary>
        public IList<Guid> Ids {
            get { return GetList<Guid>(nameof(Ids).ToLower()); }
            set { SetParameterValue(nameof(Ids).ToLower(), value); }
        }

        /// <summary>
        /// start date range to archive alerts (including) this date (use format "yyyy-MM-dd" or the new format "yyyy-MM-ddThh:mm:ss")
        /// </summary>
        public DateTime? StartDate {
            get { return GetParameterValue<DateTime?>(nameof(StartDate).ToLower()); }
            set { SetParameterValue(nameof(StartDate).ToLower(), value); }
        }

        /// <summary>
        /// archive by alert type
        /// </summary>
        public string Type {
            get { return GetParameterValue<string>(nameof(Type).ToLower()); }
            set { SetParameterValue(nameof(Type).ToLower(), value); }
        }

    }
    /// <summary>
    /// Archive one or more alerts.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse ArchiveAlerts(ArchiveAlertsRequest request);
        Task<SuccessResponse> ArchiveAlertsAsync(ArchiveAlertsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse ArchiveAlerts(ArchiveAlertsRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> ArchiveAlertsAsync(ArchiveAlertsRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
