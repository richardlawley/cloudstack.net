using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class QuotaTariffUpdateRequest : APIRequest
    {
        public QuotaTariffUpdateRequest() : base("quotaTariffUpdate") {}

        /// <summary>
        /// The effective start date on/after which the quota tariff is effective and older tariffs are no longer used for the usage type. Use yyyy-MM-dd as the date format, e.g. startDate=2009-06-03.
        /// </summary>
        public DateTime StartDate {
            get { return GetParameterValue<DateTime>(nameof(StartDate).ToLower()); }
            set { SetParameterValue(nameof(StartDate).ToLower(), value); }
        }

        /// <summary>
        /// Integer value for the usage type of the resource
        /// </summary>
        public int? UsageType {
            get { return GetParameterValue<int?>(nameof(UsageType).ToLower()); }
            set { SetParameterValue(nameof(UsageType).ToLower(), value); }
        }

        /// <summary>
        /// The quota tariff value of the resource as per the default unit
        /// </summary>
        public Double Value {
            get { return GetParameterValue<Double>(nameof(Value).ToLower()); }
            set { SetParameterValue(nameof(Value).ToLower(), value); }
        }

    }
    /// <summary>
    /// Update the tariff plan for a resource
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        QuotaTariffResponse QuotaTariffUpdate(QuotaTariffUpdateRequest request);
        Task<QuotaTariffResponse> QuotaTariffUpdateAsync(QuotaTariffUpdateRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public QuotaTariffResponse QuotaTariffUpdate(QuotaTariffUpdateRequest request) => _proxy.Request<QuotaTariffResponse>(request);
        public Task<QuotaTariffResponse> QuotaTariffUpdateAsync(QuotaTariffUpdateRequest request) => _proxy.RequestAsync<QuotaTariffResponse>(request);
    }
}
