using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListIsoPermissionsRequest : APIRequest
    {
        public ListIsoPermissionsRequest() : base("listIsoPermissions") {}

        /// <summary>
        /// the template ID
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// List iso visibility and all accounts that have permissions to view this iso.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        TemplatePermissionsResponse ListIsoPermissions(ListIsoPermissionsRequest request);
        Task<TemplatePermissionsResponse> ListIsoPermissionsAsync(ListIsoPermissionsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public TemplatePermissionsResponse ListIsoPermissions(ListIsoPermissionsRequest request) => Proxy.Request<TemplatePermissionsResponse>(request);
        public Task<TemplatePermissionsResponse> ListIsoPermissionsAsync(ListIsoPermissionsRequest request) => Proxy.RequestAsync<TemplatePermissionsResponse>(request);
    }
}
