using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// Domain for which quota credits need to be added
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// Value of the credits to be added+, subtracted-
        /// </summary>
        public Double Value {
            get { return (Double) Parameters[nameof(Value).ToLower()]; }
            set { Parameters[nameof(Value).ToLower()] = value; }
        }

        /// <summary>
        /// Minimum balance threshold of the account
        /// </summary>
        public Double Min_balance {
            get { return (Double) Parameters[nameof(Min_balance).ToLower()]; }
            set { Parameters[nameof(Min_balance).ToLower()] = value; }
        }

        /// <summary>
        /// Account for which quota enforce is set to false will not be locked when there is no credit balance
        /// </summary>
        public bool? Quota_enforce {
            get { return (bool?) Parameters[nameof(Quota_enforce).ToLower()]; }
            set { Parameters[nameof(Quota_enforce).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Add +-credits to an account
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        QuotaCreditsResponse QuotaCredits(QuotaCreditsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public QuotaCreditsResponse QuotaCredits(QuotaCreditsRequest request) => _proxy.Request<QuotaCreditsResponse>(request);
    }
}
