using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class QuotaStatementRequest : APIRequest
    {
        public QuotaStatementRequest() : base("quotaStatement") {}

        /// <summary>
        /// Optional, Account Id for which statement needs to be generated
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// Optional, If domain Id is given and the caller is domain admin then the statement is generated for domain.
        /// </summary>
        public Guid DomainId {
            get { return GetParameterValue<Guid>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// End date range for quota query. Use yyyy-MM-dd as the date format, e.g. startDate=2009-06-03.
        /// </summary>
        public DateTime EndDate {
            get { return GetParameterValue<DateTime>(nameof(EndDate).ToLower()); }
            set { SetParameterValue(nameof(EndDate).ToLower(), value); }
        }

        /// <summary>
        /// Start date range quota query. Use yyyy-MM-dd as the date format, e.g. startDate=2009-06-01.
        /// </summary>
        public DateTime StartDate {
            get { return GetParameterValue<DateTime>(nameof(StartDate).ToLower()); }
            set { SetParameterValue(nameof(StartDate).ToLower(), value); }
        }

        /// <summary>
        /// List usage records for the specified account
        /// </summary>
        public Guid? AccountId {
            get { return GetParameterValue<Guid?>(nameof(AccountId).ToLower()); }
            set { SetParameterValue(nameof(AccountId).ToLower(), value); }
        }

        /// <summary>
        /// List quota usage records for the specified usage type
        /// </summary>
        public int? Type {
            get { return GetParameterValue<int?>(nameof(Type).ToLower()); }
            set { SetParameterValue(nameof(Type).ToLower(), value); }
        }

    }
    /// <summary>
    /// Create a quota statement
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        QuotaStatementItemResponse QuotaStatement(QuotaStatementRequest request);
        Task<QuotaStatementItemResponse> QuotaStatementAsync(QuotaStatementRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public QuotaStatementItemResponse QuotaStatement(QuotaStatementRequest request) => _proxy.Request<QuotaStatementItemResponse>(request);
        public Task<QuotaStatementItemResponse> QuotaStatementAsync(QuotaStatementRequest request) => _proxy.RequestAsync<QuotaStatementItemResponse>(request);
    }
}
