using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteAlertsRequest : APIRequest
    {
        public DeleteAlertsRequest() : base("deleteAlerts") {}

        /// <summary>
        /// end date range to delete alerts (including) this date (use format "yyyy-MM-dd" or the new format "yyyy-MM-ddThh:mm:ss")
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
        /// start date range to delete alerts (including) this date (use format "yyyy-MM-dd" or the new format "yyyy-MM-ddThh:mm:ss")
        /// </summary>
        public DateTime? StartDate {
            get { return GetParameterValue<DateTime?>(nameof(StartDate).ToLower()); }
            set { SetParameterValue(nameof(StartDate).ToLower(), value); }
        }

        /// <summary>
        /// delete by alert type
        /// </summary>
        public string Type {
            get { return GetParameterValue<string>(nameof(Type).ToLower()); }
            set { SetParameterValue(nameof(Type).ToLower(), value); }
        }

    }
    /// <summary>
    /// Delete one or more alerts.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteAlerts(DeleteAlertsRequest request);
        Task<SuccessResponse> DeleteAlertsAsync(DeleteAlertsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteAlerts(DeleteAlertsRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteAlertsAsync(DeleteAlertsRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
