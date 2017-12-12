using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class QuotaCreditsRequest : APIRequest
    {
        public QuotaCreditsRequest() : base("quotaCredits") {}

        /// <summary>
        /// Account Id for which quota credits need to be added
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// Domain for which quota credits need to be added
        /// </summary>
        public Guid DomainId {
            get { return GetParameterValue<Guid>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// Value of the credits to be added+, subtracted-
        /// </summary>
        public Double Value {
            get { return GetParameterValue<Double>(nameof(Value).ToLower()); }
            set { SetParameterValue(nameof(Value).ToLower(), value); }
        }

        /// <summary>
        /// Minimum balance threshold of the account
        /// </summary>
        public Double Min_balance {
            get { return GetParameterValue<Double>(nameof(Min_balance).ToLower()); }
            set { SetParameterValue(nameof(Min_balance).ToLower(), value); }
        }

        /// <summary>
        /// Account for which quota enforce is set to false will not be locked when there is no credit balance
        /// </summary>
        public bool? Quota_enforce {
            get { return GetParameterValue<bool?>(nameof(Quota_enforce).ToLower()); }
            set { SetParameterValue(nameof(Quota_enforce).ToLower(), value); }
        }

    }
    /// <summary>
    /// Add +-credits to an account
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        QuotaCreditsResponse QuotaCredits(QuotaCreditsRequest request);
        Task<QuotaCreditsResponse> QuotaCreditsAsync(QuotaCreditsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public QuotaCreditsResponse QuotaCredits(QuotaCreditsRequest request) => Proxy.Request<QuotaCreditsResponse>(request);
        public Task<QuotaCreditsResponse> QuotaCreditsAsync(QuotaCreditsRequest request) => Proxy.RequestAsync<QuotaCreditsResponse>(request);
    }
}
