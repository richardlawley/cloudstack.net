using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class QuotaEmailTemplateListRequest : APIListRequest
    {
        public QuotaEmailTemplateListRequest() : base("quotaEmailTemplateList") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// List by type of the quota email template, allowed types: QUOTA_LOW, QUOTA_EMPTY
        /// </summary>
        public string Templatetype {
            get { return GetParameterValue<string>(nameof(Templatetype).ToLower()); }
            set { SetParameterValue(nameof(Templatetype).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists all quota email templates
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<QuotaEmailTemplateResponse> QuotaEmailTemplateList(QuotaEmailTemplateListRequest request);
        Task<ListResponse<QuotaEmailTemplateResponse>> QuotaEmailTemplateListAsync(QuotaEmailTemplateListRequest request);
        ListResponse<QuotaEmailTemplateResponse> QuotaEmailTemplateListAllPages(QuotaEmailTemplateListRequest request);
        Task<ListResponse<QuotaEmailTemplateResponse>> QuotaEmailTemplateListAllPagesAsync(QuotaEmailTemplateListRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<QuotaEmailTemplateResponse> QuotaEmailTemplateList(QuotaEmailTemplateListRequest request) => _proxy.Request<ListResponse<QuotaEmailTemplateResponse>>(request);
        public Task<ListResponse<QuotaEmailTemplateResponse>> QuotaEmailTemplateListAsync(QuotaEmailTemplateListRequest request) => _proxy.RequestAsync<ListResponse<QuotaEmailTemplateResponse>>(request);
        public ListResponse<QuotaEmailTemplateResponse> QuotaEmailTemplateListAllPages(QuotaEmailTemplateListRequest request) => _proxy.RequestAllPages<QuotaEmailTemplateResponse>(request);
        public Task<ListResponse<QuotaEmailTemplateResponse>> QuotaEmailTemplateListAllPagesAsync(QuotaEmailTemplateListRequest request) => _proxy.RequestAllPagesAsync<QuotaEmailTemplateResponse>(request);
    }
}
