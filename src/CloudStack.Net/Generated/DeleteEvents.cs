using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteEventsRequest : APIRequest
    {
        public DeleteEventsRequest() : base("deleteEvents") {}

        /// <summary>
        /// end date range to delete events (including) this date (use format "yyyy-MM-dd" or the new format "yyyy-MM-ddThh:mm:ss")
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// the IDs of the events
        /// </summary>
        public IList<long> Ids { get; set; }

        /// <summary>
        /// start date range to delete events (including) this date (use format "yyyy-MM-dd" or the new format "yyyy-MM-ddThh:mm:ss")
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// delete by event type
        /// </summary>
        public string Type { get; set; }

    }
    /// <summary>
    /// Delete one or more events.
    /// </summary>
    /// <summary>
    /// Delete one or more events.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteEvents(DeleteEventsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteEvents(DeleteEventsRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
