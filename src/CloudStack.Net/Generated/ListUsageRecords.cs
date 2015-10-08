using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListUsageRecordsRequest : APIRequest
    {
        public ListUsageRecordsRequest() : base("listUsageRecords") {}

        /// <summary>
        /// End date range for usage record query (use format "yyyy-MM-dd" or the new format "yyyy-MM-dd HH:mm:ss", e.g. startDate=2015-01-01 or startdate=2015-01-01 10:30:00).
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Start date range for usage record query (use format "yyyy-MM-dd" or the new format "yyyy-MM-dd HH:mm:ss", e.g. startDate=2015-01-01 or startdate=2015-01-01 11:00:00).
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// List usage records for the specified user.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// List usage records for the specified account
        /// </summary>
        public Guid AccountId { get; set; }

        /// <summary>
        /// List usage records for the specified domain.
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// List usage records for specified project
        /// </summary>
        public Guid ProjectId { get; set; }

        /// <summary>
        /// List usage records for the specified usage type
        /// </summary>
        public long? UsageType { get; set; }

        /// <summary>
        /// List usage records for the specified usage UUID. Can be used only together with TYPE parameter.
        /// </summary>
        public string UsageId { get; set; }

    }
    /// <summary>
    /// Lists usage records for accounts
    /// </summary>
    /// <summary>
    /// Lists usage records for accounts
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<UsageRecordResponse> ListUsageRecords(ListUsageRecordsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<UsageRecordResponse> ListUsageRecords(ListUsageRecordsRequest request) => _proxy.Request<ListResponse<UsageRecordResponse>>(request);
    }
}
