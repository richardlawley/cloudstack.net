using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (DateTime) Parameters[nameof(EndDate).ToLower()]; }
            set { Parameters[nameof(EndDate).ToLower()] = value; }
        }

        /// <summary>
        /// Start date range for usage record query. Use yyyy-MM-dd as the date format, e.g. startDate=2009-06-01.
        /// </summary>
        public DateTime StartDate {
            get { return (DateTime) Parameters[nameof(StartDate).ToLower()]; }
            set { Parameters[nameof(StartDate).ToLower()] = value; }
        }

        /// <summary>
        /// List events for the specified domain.
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Generates usage records. This will generate records only if there any records to be generated, i.e if the scheduled usage job was not run or failed
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse GenerateUsageRecords(GenerateUsageRecordsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse GenerateUsageRecords(GenerateUsageRecordsRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
