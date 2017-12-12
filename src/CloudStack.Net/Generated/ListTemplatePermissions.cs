using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListTemplatePermissionsRequest : APIRequest
    {
        public ListTemplatePermissionsRequest() : base("listTemplatePermissions") {}

        /// <summary>
        /// the template ID
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// List template visibility and all accounts that have permissions to view this template.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        TemplatePermissionsResponse ListTemplatePermissions(ListTemplatePermissionsRequest request);
        Task<TemplatePermissionsResponse> ListTemplatePermissionsAsync(ListTemplatePermissionsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public TemplatePermissionsResponse ListTemplatePermissions(ListTemplatePermissionsRequest request) => Proxy.Request<TemplatePermissionsResponse>(request);
        public Task<TemplatePermissionsResponse> ListTemplatePermissionsAsync(ListTemplatePermissionsRequest request) => Proxy.RequestAsync<TemplatePermissionsResponse>(request);
    }
}
