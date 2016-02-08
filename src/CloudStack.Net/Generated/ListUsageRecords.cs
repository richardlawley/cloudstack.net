using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListUsageRecordsRequest : APIRequest
    {
        public ListUsageRecordsRequest() : base("listUsageRecords") {}

        /// <summary>
        /// End date range for usage record query (use format "yyyy-MM-dd" or the new format "yyyy-MM-dd HH:mm:ss", e.g. startDate=2015-01-01 or startdate=2015-01-01 10:30:00).
        /// </summary>
        public DateTime EndDate {
            get { return (DateTime) Parameters[nameof(EndDate).ToLower()]; }
            set { Parameters[nameof(EndDate).ToLower()] = value; }
        }

        /// <summary>
        /// Start date range for usage record query (use format "yyyy-MM-dd" or the new format "yyyy-MM-dd HH:mm:ss", e.g. startDate=2015-01-01 or startdate=2015-01-01 11:00:00).
        /// </summary>
        public DateTime StartDate {
            get { return (DateTime) Parameters[nameof(StartDate).ToLower()]; }
            set { Parameters[nameof(StartDate).ToLower()] = value; }
        }

        /// <summary>
        /// List usage records for the specified user.
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// List usage records for the specified account
        /// </summary>
        public Guid AccountId {
            get { return (Guid) Parameters[nameof(AccountId).ToLower()]; }
            set { Parameters[nameof(AccountId).ToLower()] = value; }
        }

        /// <summary>
        /// List usage records for the specified domain.
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
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
        /// List usage records for specified project
        /// </summary>
        public Guid ProjectId {
            get { return (Guid) Parameters[nameof(ProjectId).ToLower()]; }
            set { Parameters[nameof(ProjectId).ToLower()] = value; }
        }

        /// <summary>
        /// List usage records for the specified usage type
        /// </summary>
        public long? Type {
            get { return (long?) Parameters[nameof(Type).ToLower()]; }
            set { Parameters[nameof(Type).ToLower()] = value; }
        }

        /// <summary>
        /// List usage records for the specified usage UUID. Can be used only together with TYPE parameter.
        /// </summary>
        public string UsageId {
            get { return (string) Parameters[nameof(UsageId).ToLower()]; }
            set { Parameters[nameof(UsageId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists usage records for accounts
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<UsageRecordResponse> ListUsageRecords(ListUsageRecordsRequest request);
        Task<ListResponse<UsageRecordResponse>> ListUsageRecordsAsync(ListUsageRecordsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<UsageRecordResponse> ListUsageRecords(ListUsageRecordsRequest request) => _proxy.Request<ListResponse<UsageRecordResponse>>(request);
        public Task<ListResponse<UsageRecordResponse>> ListUsageRecordsAsync(ListUsageRecordsRequest request) => _proxy.RequestAsync<ListResponse<UsageRecordResponse>>(request);
    }
}
