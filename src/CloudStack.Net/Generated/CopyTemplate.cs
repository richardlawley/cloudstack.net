using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CopyTemplateRequest : APIRequest
    {
        public CopyTemplateRequest() : base("copyTemplate") {}

        /// <summary>
        /// Template ID.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// ID of the zone the template is being copied to.
        /// </summary>
        public Guid DestZoneId { get; set; }

        /// <summary>
        /// ID of the zone the template is currently hosted on. If not specified and template is cross-zone, then we will sync this template to region wide image store.
        /// </summary>
        public Guid SourceZoneId { get; set; }

    }
    /// <summary>
    /// Copies a template from one zone to another.
    /// </summary>
    /// <summary>
    /// Copies a template from one zone to another.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        TemplateResponse CopyTemplate(CopyTemplateRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public TemplateResponse CopyTemplate(CopyTemplateRequest request) => _proxy.Request<TemplateResponse>(request);
    }
}
