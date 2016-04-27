using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListEventsRequest : APIListRequest
    {
        public ListEventsRequest() : base("listEvents") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// the duration of the event
        /// </summary>
        public int? Duration {
            get { return GetParameterValue<int?>(nameof(Duration).ToLower()); }
            set { SetParameterValue(nameof(Duration).ToLower(), value); }
        }

        /// <summary>
        /// the end date range of the list you want to retrieve (use format "yyyy-MM-dd" or the new format "yyyy-MM-dd HH:mm:ss")
        /// </summary>
        public DateTime? EndDate {
            get { return GetParameterValue<DateTime?>(nameof(EndDate).ToLower()); }
            set { SetParameterValue(nameof(EndDate).ToLower(), value); }
        }

        /// <summary>
        /// the time the event was entered
        /// </summary>
        public int? EntryTime {
            get { return GetParameterValue<int?>(nameof(EntryTime).ToLower()); }
            set { SetParameterValue(nameof(EntryTime).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the event
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// defaults to false, but if true, lists all resources from the parent specified by the domainId till leaves.
        /// </summary>
        public bool? Isrecursive {
            get { return GetParameterValue<bool?>(nameof(Isrecursive).ToLower()); }
            set { SetParameterValue(nameof(Isrecursive).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// the event level (INFO, WARN, ERROR)
        /// </summary>
        public string Level {
            get { return GetParameterValue<string>(nameof(Level).ToLower()); }
            set { SetParameterValue(nameof(Level).ToLower(), value); }
        }

        /// <summary>
        /// If set to false, list only resources belonging to the command's caller; if set to true - list resources that the caller is authorized to see. Default value is false
        /// </summary>
        public bool? ListAll {
            get { return GetParameterValue<bool?>(nameof(ListAll).ToLower()); }
            set { SetParameterValue(nameof(ListAll).ToLower(), value); }
        }

        /// <summary>
        /// list objects by project
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// the start date range of the list you want to retrieve (use format "yyyy-MM-dd" or the new format "yyyy-MM-dd HH:mm:ss")
        /// </summary>
        public DateTime? StartDate {
            get { return GetParameterValue<DateTime?>(nameof(StartDate).ToLower()); }
            set { SetParameterValue(nameof(StartDate).ToLower(), value); }
        }

        /// <summary>
        /// the event type (see event types)
        /// </summary>
        public string Type {
            get { return GetParameterValue<string>(nameof(Type).ToLower()); }
            set { SetParameterValue(nameof(Type).ToLower(), value); }
        }

    }
    /// <summary>
    /// A command to list events.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<EventResponse> ListEvents(ListEventsRequest request);
        Task<ListResponse<EventResponse>> ListEventsAsync(ListEventsRequest request);
        ListResponse<EventResponse> ListEventsAllPages(ListEventsRequest request);
        Task<ListResponse<EventResponse>> ListEventsAllPagesAsync(ListEventsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<EventResponse> ListEvents(ListEventsRequest request) => _proxy.Request<ListResponse<EventResponse>>(request);
        public Task<ListResponse<EventResponse>> ListEventsAsync(ListEventsRequest request) => _proxy.RequestAsync<ListResponse<EventResponse>>(request);
        public ListResponse<EventResponse> ListEventsAllPages(ListEventsRequest request) => _proxy.RequestAllPages<EventResponse>(request);
        public Task<ListResponse<EventResponse>> ListEventsAllPagesAsync(ListEventsRequest request) => _proxy.RequestAllPagesAsync<EventResponse>(request);
    }
}
