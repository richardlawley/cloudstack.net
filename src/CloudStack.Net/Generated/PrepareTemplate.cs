using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class PrepareTemplateRequest : APIRequest
    {
        public PrepareTemplateRequest() : base("prepareTemplate") {}

        /// <summary>
        /// template ID of the template to be prepared in primary storage(s).
        /// </summary>
        public Guid TemplateId { get; set; }

        /// <summary>
        /// zone ID of the template to be prepared in primary storage(s).
        /// </summary>
        public Guid ZoneId { get; set; }

        /// <summary>
        /// storage pool ID of the primary storage pool to which the template should be prepared. If it is not provided the template is prepared on all the available primary storage pools.
        /// </summary>
        public Guid StorageId { get; set; }

    }
    /// <summary>
    /// load template into primary storage
    /// </summary>
    /// <summary>
    /// load template into primary storage
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        TemplateResponse PrepareTemplate(PrepareTemplateRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public TemplateResponse PrepareTemplate(PrepareTemplateRequest request) => _proxy.Request<TemplateResponse>(request);
    }
}
