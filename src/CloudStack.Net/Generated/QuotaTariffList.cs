using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class QuotaTariffListRequest : APIListRequest
    {
        public QuotaTariffListRequest() : base("quotaTariffList") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// The effective start date on/after which the quota tariff is effective and older tariffs are no longer used for the usage type. Use yyyy-MM-dd as the date format, e.g. startDate=2009-06-03.
        /// </summary>
        public DateTime? Startdate {
            get { return GetParameterValue<DateTime?>(nameof(Startdate).ToLower()); }
            set { SetParameterValue(nameof(Startdate).ToLower(), value); }
        }

        /// <summary>
        /// Usage type of the resource
        /// </summary>
        public int? UsageType {
            get { return GetParameterValue<int?>(nameof(UsageType).ToLower()); }
            set { SetParameterValue(nameof(UsageType).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists all quota tariff plans
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<QuotaTariffResponse> QuotaTariffList(QuotaTariffListRequest request);
        Task<ListResponse<QuotaTariffResponse>> QuotaTariffListAsync(QuotaTariffListRequest request);
        ListResponse<QuotaTariffResponse> QuotaTariffListAllPages(QuotaTariffListRequest request);
        Task<ListResponse<QuotaTariffResponse>> QuotaTariffListAllPagesAsync(QuotaTariffListRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<QuotaTariffResponse> QuotaTariffList(QuotaTariffListRequest request) => Proxy.Request<ListResponse<QuotaTariffResponse>>(request);
        public Task<ListResponse<QuotaTariffResponse>> QuotaTariffListAsync(QuotaTariffListRequest request) => Proxy.RequestAsync<ListResponse<QuotaTariffResponse>>(request);
        public ListResponse<QuotaTariffResponse> QuotaTariffListAllPages(QuotaTariffListRequest request) => Proxy.RequestAllPages<QuotaTariffResponse>(request);
        public Task<ListResponse<QuotaTariffResponse>> QuotaTariffListAllPagesAsync(QuotaTariffListRequest request) => Proxy.RequestAllPagesAsync<QuotaTariffResponse>(request);
    }
}
