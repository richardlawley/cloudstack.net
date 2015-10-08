using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ExtractTemplateRequest : APIRequest
    {
        public ExtractTemplateRequest() : base("extractTemplate") {}

        /// <summary>
        /// the ID of the template
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// the mode of extraction - HTTP_DOWNLOAD or FTP_UPLOAD
        /// </summary>
        public string Mode { get; set; }

        /// <summary>
        /// the url to which the ISO would be extracted
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// the ID of the zone where the ISO is originally located
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// Extracts a template
    /// </summary>
    /// <summary>
    /// Extracts a template
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ExtractResponse ExtractTemplate(ExtractTemplateRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ExtractResponse ExtractTemplate(ExtractTemplateRequest request) => _proxy.Request<ExtractResponse>(request);
    }
}
