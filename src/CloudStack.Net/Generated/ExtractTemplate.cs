using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ExtractTemplateRequest : APIRequest
    {
        public ExtractTemplateRequest() : base("extractTemplate") {}

        /// <summary>
        /// the ID of the template
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the mode of extraction - HTTP_DOWNLOAD or FTP_UPLOAD
        /// </summary>
        public string Mode {
            get { return GetParameterValue<string>(nameof(Mode).ToLower()); }
            set { SetParameterValue(nameof(Mode).ToLower(), value); }
        }

        /// <summary>
        /// the url to which the ISO would be extracted
        /// </summary>
        public string Url {
            get { return GetParameterValue<string>(nameof(Url).ToLower()); }
            set { SetParameterValue(nameof(Url).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the zone where the ISO is originally located
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Extracts a template
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ExtractTemplate(ExtractTemplateRequest request);
        Task<AsyncJobResponse> ExtractTemplateAsync(ExtractTemplateRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ExtractTemplate(ExtractTemplateRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> ExtractTemplateAsync(ExtractTemplateRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
