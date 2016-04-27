using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class QuotaSummaryRequest : APIListRequest
    {
        public QuotaSummaryRequest() : base("quotaSummary") {}

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
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
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
        /// Optional, to list all accounts irrespective of the quota activity
        /// </summary>
        public bool? ListAll {
            get { return GetParameterValue<bool?>(nameof(ListAll).ToLower()); }
            set { SetParameterValue(nameof(ListAll).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists balance and quota usage for all accounts
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<QuotaSummaryResponse> QuotaSummary(QuotaSummaryRequest request);
        Task<ListResponse<QuotaSummaryResponse>> QuotaSummaryAsync(QuotaSummaryRequest request);
        ListResponse<QuotaSummaryResponse> QuotaSummaryAllPages(QuotaSummaryRequest request);
        Task<ListResponse<QuotaSummaryResponse>> QuotaSummaryAllPagesAsync(QuotaSummaryRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<QuotaSummaryResponse> QuotaSummary(QuotaSummaryRequest request) => _proxy.Request<ListResponse<QuotaSummaryResponse>>(request);
        public Task<ListResponse<QuotaSummaryResponse>> QuotaSummaryAsync(QuotaSummaryRequest request) => _proxy.RequestAsync<ListResponse<QuotaSummaryResponse>>(request);
        public ListResponse<QuotaSummaryResponse> QuotaSummaryAllPages(QuotaSummaryRequest request) => _proxy.RequestAllPages<QuotaSummaryResponse>(request);
        public Task<ListResponse<QuotaSummaryResponse>> QuotaSummaryAllPagesAsync(QuotaSummaryRequest request) => _proxy.RequestAllPagesAsync<QuotaSummaryResponse>(request);
    }
}
