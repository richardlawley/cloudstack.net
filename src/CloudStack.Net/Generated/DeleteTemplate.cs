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
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of zone of the template
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Deletes a template from the system. All virtual machines using the deleted template will not be affected.
    /// </summary>
    /// <summary>
    /// Deletes a template from the system. All virtual machines using the deleted template will not be affected.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteTemplate(DeleteTemplateRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteTemplate(DeleteTemplateRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
