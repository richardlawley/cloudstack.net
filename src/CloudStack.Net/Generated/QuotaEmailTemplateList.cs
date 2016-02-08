using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class QuotaEmailTemplateListRequest : APIRequest
    {
        public QuotaEmailTemplateListRequest() : base("quotaEmailTemplateList") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        public int? Page {
            get { return (int?) Parameters[nameof(Page).ToLower()]; }
            set { Parameters[nameof(Page).ToLower()] = value; }
        }

        public int? PageSize {
            get { return (int?) Parameters[nameof(PageSize).ToLower()]; }
            set { Parameters[nameof(PageSize).ToLower()] = value; }
        }

        /// <summary>
        /// List by type of the quota email template, allowed types: QUOTA_LOW, QUOTA_EMPTY
        /// </summary>
        public string Templatetype {
            get { return (string) Parameters[nameof(Templatetype).ToLower()]; }
            set { Parameters[nameof(Templatetype).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists all quota email templates
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<QuotaEmailTemplateResponse> QuotaEmailTemplateList(QuotaEmailTemplateListRequest request);
        Task<ListResponse<QuotaEmailTemplateResponse>> QuotaEmailTemplateListAsync(QuotaEmailTemplateListRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<QuotaEmailTemplateResponse> QuotaEmailTemplateList(QuotaEmailTemplateListRequest request) => _proxy.Request<ListResponse<QuotaEmailTemplateResponse>>(request);
        public Task<ListResponse<QuotaEmailTemplateResponse>> QuotaEmailTemplateListAsync(QuotaEmailTemplateListRequest request) => _proxy.RequestAsync<ListResponse<QuotaEmailTemplateResponse>>(request);
    }
}
