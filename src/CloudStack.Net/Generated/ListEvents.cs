using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListEventsRequest : APIRequest
    {
        public ListEventsRequest() : base("listEvents") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// the duration of the event
        /// </summary>
        public int? Duration { get; set; }

        /// <summary>
        /// the end date range of the list you want to retrieve (use format "yyyy-MM-dd" or the new format "yyyy-MM-dd HH:mm:ss")
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// the time the event was entered
        /// </summary>
        public int? EntryTime { get; set; }

        /// <summary>
        /// the ID of the event
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// defaults to false, but if true, lists all resources from the parent specified by the domainId till leaves.
        /// </summary>
        public bool? Recursive { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// the event level (INFO, WARN, ERROR)
        /// </summary>
        public string Level { get; set; }

        /// <summary>
        /// If set to false, list only resources belonging to the command's caller; if set to true - list resources that the caller is authorized to see. Default value is false
        /// </summary>
        public bool? ListAll { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// list objects by project
        /// </summary>
        public Guid ProjectId { get; set; }

        /// <summary>
        /// the start date range of the list you want to retrieve (use format "yyyy-MM-dd" or the new format "yyyy-MM-dd HH:mm:ss")
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// the event type (see event types)
        /// </summary>
        public string Type { get; set; }

    }
    /// <summary>
    /// A command to list events.
    /// </summary>
    /// <summary>
    /// A command to list events.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<EventResponse> ListEvents(ListEventsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<EventResponse> ListEvents(ListEventsRequest request) => _proxy.Request<ListResponse<EventResponse>>(request);
    }
}
