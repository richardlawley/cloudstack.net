using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListUsageRecordsRequest : APIListRequest
    {
        public ListUsageRecordsRequest() : base("listUsageRecords") {}

        /// <summary>
        /// End date range for usage record query (use format "yyyy-MM-dd" or the new format "yyyy-MM-dd HH:mm:ss", e.g. startDate=2015-01-01 or startdate=2015-01-01 10:30:00).
        /// </summary>
        public DateTime EndDate {
            get { return GetParameterValue<DateTime>(nameof(EndDate).ToLower()); }
            set { SetParameterValue(nameof(EndDate).ToLower(), value); }
        }

        /// <summary>
        /// Start date range for usage record query (use format "yyyy-MM-dd" or the new format "yyyy-MM-dd HH:mm:ss", e.g. startDate=2015-01-01 or startdate=2015-01-01 11:00:00).
        /// </summary>
        public DateTime StartDate {
            get { return GetParameterValue<DateTime>(nameof(StartDate).ToLower()); }
            set { SetParameterValue(nameof(StartDate).ToLower(), value); }
        }

        /// <summary>
        /// List usage records for the specified user.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// List usage records for the specified account
        /// </summary>
        public Guid AccountId {
            get { return GetParameterValue<Guid>(nameof(AccountId).ToLower()); }
            set { SetParameterValue(nameof(AccountId).ToLower(), value); }
        }

        /// <summary>
        /// List usage records for the specified domain.
        /// </summary>
        public Guid DomainId {
            get { return GetParameterValue<Guid>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// List usage records for specified project
        /// </summary>
        public Guid ProjectId {
            get { return GetParameterValue<Guid>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// List usage records for the specified usage type
        /// </summary>
        public long? Type {
            get { return GetParameterValue<long?>(nameof(Type).ToLower()); }
            set { SetParameterValue(nameof(Type).ToLower(), value); }
        }

        /// <summary>
        /// List usage records for the specified usage UUID. Can be used only together with TYPE parameter.
        /// </summary>
        public string UsageId {
            get { return GetParameterValue<string>(nameof(UsageId).ToLower()); }
            set { SetParameterValue(nameof(UsageId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists usage records for accounts
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<UsageRecordResponse> ListUsageRecords(ListUsageRecordsRequest request);
        Task<ListResponse<UsageRecordResponse>> ListUsageRecordsAsync(ListUsageRecordsRequest request);
        ListResponse<UsageRecordResponse> ListUsageRecordsAllPages(ListUsageRecordsRequest request);
        Task<ListResponse<UsageRecordResponse>> ListUsageRecordsAllPagesAsync(ListUsageRecordsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<UsageRecordResponse> ListUsageRecords(ListUsageRecordsRequest request) => _proxy.Request<ListResponse<UsageRecordResponse>>(request);
        public Task<ListResponse<UsageRecordResponse>> ListUsageRecordsAsync(ListUsageRecordsRequest request) => _proxy.RequestAsync<ListResponse<UsageRecordResponse>>(request);
        public ListResponse<UsageRecordResponse> ListUsageRecordsAllPages(ListUsageRecordsRequest request) => _proxy.RequestAllPages<UsageRecordResponse>(request);
        public Task<ListResponse<UsageRecordResponse>> ListUsageRecordsAllPagesAsync(ListUsageRecordsRequest request) => _proxy.RequestAllPagesAsync<UsageRecordResponse>(request);
    }
}
