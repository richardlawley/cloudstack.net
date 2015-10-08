using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ArchiveEventsRequest : APIRequest
    {
        public ArchiveEventsRequest() : base("archiveEvents") {}

        /// <summary>
        /// end date range to archive events (including) this date (use format "yyyy-MM-dd" or the new format "yyyy-MM-ddThh:mm:ss")
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// the IDs of the events
        /// </summary>
        public IList<long> Ids { get; set; }

        /// <summary>
        /// start date range to archive events (including) this date (use format "yyyy-MM-dd" or the new format "yyyy-MM-ddThh:mm:ss")
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// archive by event type
        /// </summary>
        public string Type { get; set; }

    }
    /// <summary>
    /// Archive one or more events.
    /// </summary>
    /// <summary>
    /// Archive one or more events.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse ArchiveEvents(ArchiveEventsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse ArchiveEvents(ArchiveEventsRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
