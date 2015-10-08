using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteTemplateRequest : APIRequest
    {
        public DeleteTemplateRequest() : base("deleteTemplate") {}

        /// <summary>
        /// the ID of the template
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// the ID of zone of the template
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// Deletes a template from the system. All virtual machines using the deleted template will not be affected.
    /// </summary>
    /// <summary>
    /// Deletes a template from the system. All virtual machines using the deleted template will not be affected.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteTemplate(DeleteTemplateRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteTemplate(DeleteTemplateRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
