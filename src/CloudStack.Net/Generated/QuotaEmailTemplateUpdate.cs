using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class QuotaEmailTemplateUpdateRequest : APIRequest
    {
        public QuotaEmailTemplateUpdateRequest() : base("quotaEmailTemplateUpdate") {}

        /// <summary>
        /// The quota email template body, max: 500k characters
        /// </summary>
        public string TemplateBody {
            get { return GetParameterValue<string>(nameof(TemplateBody).ToLower()); }
            set { SetParameterValue(nameof(TemplateBody).ToLower(), value); }
        }

        /// <summary>
        /// The quota email template subject, max: 77 characters
        /// </summary>
        public string TemplateSubject {
            get { return GetParameterValue<string>(nameof(TemplateSubject).ToLower()); }
            set { SetParameterValue(nameof(TemplateSubject).ToLower(), value); }
        }

        /// <summary>
        /// Type of the quota email template, allowed types: QUOTA_LOW, QUOTA_EMPTY
        /// </summary>
        public string Templatetype {
            get { return GetParameterValue<string>(nameof(Templatetype).ToLower()); }
            set { SetParameterValue(nameof(Templatetype).ToLower(), value); }
        }

        /// <summary>
        /// The locale of the email text
        /// </summary>
        public string Locale {
            get { return GetParameterValue<string>(nameof(Locale).ToLower()); }
            set { SetParameterValue(nameof(Locale).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates existing email templates for quota alerts
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse QuotaEmailTemplateUpdate(QuotaEmailTemplateUpdateRequest request);
        Task<SuccessResponse> QuotaEmailTemplateUpdateAsync(QuotaEmailTemplateUpdateRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse QuotaEmailTemplateUpdate(QuotaEmailTemplateUpdateRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> QuotaEmailTemplateUpdateAsync(QuotaEmailTemplateUpdateRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
