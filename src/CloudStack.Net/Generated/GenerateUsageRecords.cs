using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class GenerateUsageRecordsRequest : APIRequest
    {
        public GenerateUsageRecordsRequest() : base("generateUsageRecords") {}

        /// <summary>
        /// End date range for usage record query. Use yyyy-MM-dd as the date format, e.g. startDate=2009-06-03.
        /// </summary>
        public DateTime EndDate {
            get { return GetParameterValue<DateTime>(nameof(EndDate).ToLower()); }
            set { SetParameterValue(nameof(EndDate).ToLower(), value); }
        }

        /// <summary>
        /// Start date range for usage record query. Use yyyy-MM-dd as the date format, e.g. startDate=2009-06-01.
        /// </summary>
        public DateTime StartDate {
            get { return GetParameterValue<DateTime>(nameof(StartDate).ToLower()); }
            set { SetParameterValue(nameof(StartDate).ToLower(), value); }
        }

        /// <summary>
        /// List events for the specified domain.
        /// </summary>
        public Guid DomainId {
            get { return GetParameterValue<Guid>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Generates usage records. This will generate records only if there any records to be generated, i.e if the scheduled usage job was not run or failed
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse GenerateUsageRecords(GenerateUsageRecordsRequest request);
        Task<SuccessResponse> GenerateUsageRecordsAsync(GenerateUsageRecordsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse GenerateUsageRecords(GenerateUsageRecordsRequest request) => _proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> GenerateUsageRecordsAsync(GenerateUsageRecordsRequest request) => _proxy.RequestAsync<SuccessResponse>(request);
    }
}
