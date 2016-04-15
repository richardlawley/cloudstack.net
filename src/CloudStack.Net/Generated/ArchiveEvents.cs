using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ArchiveEventsRequest : APIRequest
    {
        public ArchiveEventsRequest() : base("archiveEvents") {}

        /// <summary>
        /// end date range to archive events (including) this date (use format "yyyy-MM-dd" or the new format "yyyy-MM-ddThh:mm:ss")
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
        /// start date range to archive events (including) this date (use format "yyyy-MM-dd" or the new format "yyyy-MM-ddThh:mm:ss")
        /// </summary>
        public DateTime? StartDate {
            get { return GetParameterValue<DateTime?>(nameof(StartDate).ToLower()); }
            set { SetParameterValue(nameof(StartDate).ToLower(), value); }
        }

        /// <summary>
        /// archive by event type
        /// </summary>
        public string Type {
            get { return GetParameterValue<string>(nameof(Type).ToLower()); }
            set { SetParameterValue(nameof(Type).ToLower(), value); }
        }

    }
    /// <summary>
    /// Archive one or more events.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse ArchiveEvents(ArchiveEventsRequest request);
        Task<SuccessResponse> ArchiveEventsAsync(ArchiveEventsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse ArchiveEvents(ArchiveEventsRequest request) => _proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> ArchiveEventsAsync(ArchiveEventsRequest request) => _proxy.RequestAsync<SuccessResponse>(request);
    }
}
