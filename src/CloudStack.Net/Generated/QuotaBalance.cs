using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class QuotaBalanceRequest : APIRequest
    {
        public QuotaBalanceRequest() : base("quotaBalance") {}

        /// <summary>
        /// Account Id for which statement needs to be generated
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// If domain Id is given and the caller is domain admin then the statement is generated for domain.
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// List usage records for the specified account
        /// </summary>
        public Guid AccountId {
            get { return (Guid) Parameters[nameof(AccountId).ToLower()]; }
            set { Parameters[nameof(AccountId).ToLower()] = value; }
        }

        /// <summary>
        /// End date range for quota query. Use yyyy-MM-dd as the date format, e.g. startDate=2009-06-03.
        /// </summary>
        public DateTime? EndDate {
            get { return (DateTime?) Parameters[nameof(EndDate).ToLower()]; }
            set { Parameters[nameof(EndDate).ToLower()] = value; }
        }

        /// <summary>
        /// Start date range quota query. Use yyyy-MM-dd as the date format, e.g. startDate=2009-06-01.
        /// </summary>
        public DateTime? StartDate {
            get { return (DateTime?) Parameters[nameof(StartDate).ToLower()]; }
            set { Parameters[nameof(StartDate).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Create a quota balance statement
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        QuotaStatementItemResponse QuotaBalance(QuotaBalanceRequest request);
        Task<QuotaStatementItemResponse> QuotaBalanceAsync(QuotaBalanceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public QuotaStatementItemResponse QuotaBalance(QuotaBalanceRequest request) => _proxy.Request<QuotaStatementItemResponse>(request);
        public Task<QuotaStatementItemResponse> QuotaBalanceAsync(QuotaBalanceRequest request) => _proxy.RequestAsync<QuotaStatementItemResponse>(request);
    }
}
