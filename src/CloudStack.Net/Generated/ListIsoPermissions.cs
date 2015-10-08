using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListIsoPermissionsRequest : APIRequest
    {
        public ListIsoPermissionsRequest() : base("listIsoPermissions") {}

        /// <summary>
        /// the template ID
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// List iso visibility and all accounts that have permissions to view this iso.
    /// </summary>
    /// <summary>
    /// List iso visibility and all accounts that have permissions to view this iso.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        TemplatePermissionsResponse ListIsoPermissions(ListIsoPermissionsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public TemplatePermissionsResponse ListIsoPermissions(ListIsoPermissionsRequest request) => _proxy.Request<TemplatePermissionsResponse>(request);
    }
}
