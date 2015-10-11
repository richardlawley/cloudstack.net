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
        public DateTime? EndDate {
            get { return (DateTime?) Parameters[nameof(EndDate).ToLower()]; }
            set { Parameters[nameof(EndDate).ToLower()] = value; }
        }

        /// <summary>
        /// the IDs of the events
        /// </summary>
        public IList<Guid> Ids {
            get { return (IList<Guid>) Parameters[nameof(Ids).ToLower()]; }
            set { Parameters[nameof(Ids).ToLower()] = value; }
        }

        /// <summary>
        /// start date range to delete events (including) this date (use format "yyyy-MM-dd" or the new format "yyyy-MM-ddThh:mm:ss")
        /// </summary>
        public DateTime? StartDate {
            get { return (DateTime?) Parameters[nameof(StartDate).ToLower()]; }
            set { Parameters[nameof(StartDate).ToLower()] = value; }
        }

        /// <summary>
        /// delete by event type
        /// </summary>
        public string Type {
            get { return (string) Parameters[nameof(Type).ToLower()]; }
            set { Parameters[nameof(Type).ToLower()] = value; }
        }

    }
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
