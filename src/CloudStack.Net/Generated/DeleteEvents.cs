using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteEventsRequest : APIRequest
    {
        public DeleteEventsRequest() : base("deleteEvents") {}

        /// <summary>
        /// end date range to delete events (including) this date (use format "yyyy-MM-dd" or the new format "yyyy-MM-ddThh:mm:ss")
        /// </summary>
        public DateTime? EndDate {
            get { return GetParameterValue<DateTime?>(nameof(EndDate).ToLower()); }
            set { SetParameterValue(nameof(EndDate).ToLower(), value); }
        }

        /// <summary>
        /// the IDs of the events
        /// </summary>
        public IList<Guid> Ids {
            get { return GetList<Guid>(nameof(Ids).ToLower()); }
            set { SetParameterValue(nameof(Ids).ToLower(), value); }
        }

        /// <summary>
        /// start date range to delete events (including) this date (use format "yyyy-MM-dd" or the new format "yyyy-MM-ddThh:mm:ss")
        /// </summary>
        public DateTime? StartDate {
            get { return GetParameterValue<DateTime?>(nameof(StartDate).ToLower()); }
            set { SetParameterValue(nameof(StartDate).ToLower(), value); }
        }

        /// <summary>
        /// delete by event type
        /// </summary>
        public string Type {
            get { return GetParameterValue<string>(nameof(Type).ToLower()); }
            set { SetParameterValue(nameof(Type).ToLower(), value); }
        }

    }
    /// <summary>
    /// Delete one or more events.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteEvents(DeleteEventsRequest request);
        Task<SuccessResponse> DeleteEventsAsync(DeleteEventsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteEvents(DeleteEventsRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteEventsAsync(DeleteEventsRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
