using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the ID of zone of the template
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a template from the system. All virtual machines using the deleted template will not be affected.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteTemplate(DeleteTemplateRequest request);
        Task<AsyncJobResponse> DeleteTemplateAsync(DeleteTemplateRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteTemplate(DeleteTemplateRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteTemplateAsync(DeleteTemplateRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
