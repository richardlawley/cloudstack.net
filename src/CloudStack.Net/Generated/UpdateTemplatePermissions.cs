using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateTemplatePermissionsRequest : APIRequest
    {
        public UpdateTemplatePermissionsRequest() : base("updateTemplatePermissions") {}

        /// <summary>
        /// the template ID
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// a comma delimited list of accounts. If specified, "op" parameter has to be passed in.
        /// </summary>
        public IList<string> AccountNames { get; set; }

        /// <summary>
        /// true if the template/iso is extractable, false other wise. Can be set only by root admin
        /// </summary>
        public bool? IsExtractable { get; set; }

        /// <summary>
        /// true for featured template/iso, false otherwise
        /// </summary>
        public bool? Featured { get; set; }

        /// <summary>
        /// true for public template/iso, false for private templates/isos
        /// </summary>
        public bool? IsPublic { get; set; }

        /// <summary>
        /// permission operator (add, remove, reset)
        /// </summary>
        public string Operation { get; set; }

        /// <summary>
        /// a comma delimited list of projects. If specified, "op" parameter has to be passed in.
        /// </summary>
        public IList<long> ProjectIds { get; set; }

    }
    /// <summary>
    /// Updates a template visibility permissions. A public template is visible to all accounts within the same domain. A private template is visible only to the owner of the template. A priviledged template is a private template with account permissions added. Only accounts specified under the template permissions are visible to them.
    /// </summary>
    /// <summary>
    /// Updates a template visibility permissions. A public template is visible to all accounts within the same domain. A private template is visible only to the owner of the template. A priviledged template is a private template with account permissions added. Only accounts specified under the template permissions are visible to them.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse UpdateTemplatePermissions(UpdateTemplatePermissionsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse UpdateTemplatePermissions(UpdateTemplatePermissionsRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
