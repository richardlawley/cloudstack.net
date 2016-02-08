using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListAlertsRequest : APIRequest
    {
        public ListAlertsRequest() : base("listAlerts") {}

        /// <summary>
        /// the ID of the alert
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
        /// list by alert name
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
        /// list by alert type
        /// </summary>
        public string Type {
            get { return (string) Parameters[nameof(Type).ToLower()]; }
            set { Parameters[nameof(Type).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists all alerts.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<AlertResponse> ListAlerts(ListAlertsRequest request);
        Task<ListResponse<AlertResponse>> ListAlertsAsync(ListAlertsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<AlertResponse> ListAlerts(ListAlertsRequest request) => _proxy.Request<ListResponse<AlertResponse>>(request);
        public Task<ListResponse<AlertResponse>> ListAlertsAsync(ListAlertsRequest request) => _proxy.RequestAsync<ListResponse<AlertResponse>>(request);
    }
}
