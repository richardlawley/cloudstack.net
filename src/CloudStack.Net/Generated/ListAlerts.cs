using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListAlertsRequest : APIListRequest
    {
        public ListAlertsRequest() : base("listAlerts") {}

        /// <summary>
        /// the ID of the alert
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
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
        /// list by alert name
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// list by alert type
        /// </summary>
        public string Type {
            get { return GetParameterValue<string>(nameof(Type).ToLower()); }
            set { SetParameterValue(nameof(Type).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists all alerts.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<AlertResponse> ListAlerts(ListAlertsRequest request);
        Task<ListResponse<AlertResponse>> ListAlertsAsync(ListAlertsRequest request);
        ListResponse<AlertResponse> ListAlertsAllPages(ListAlertsRequest request);
        Task<ListResponse<AlertResponse>> ListAlertsAllPagesAsync(ListAlertsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<AlertResponse> ListAlerts(ListAlertsRequest request) => _proxy.Request<ListResponse<AlertResponse>>(request);
        public Task<ListResponse<AlertResponse>> ListAlertsAsync(ListAlertsRequest request) => _proxy.RequestAsync<ListResponse<AlertResponse>>(request);
        public ListResponse<AlertResponse> ListAlertsAllPages(ListAlertsRequest request) => _proxy.RequestAllPages<AlertResponse>(request);
        public Task<ListResponse<AlertResponse>> ListAlertsAllPagesAsync(ListAlertsRequest request) => _proxy.RequestAllPagesAsync<AlertResponse>(request);
    }
}
