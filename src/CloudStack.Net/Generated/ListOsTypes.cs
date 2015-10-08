using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListOsTypesRequest : APIRequest
    {
        public ListOsTypesRequest() : base("listOsTypes") {}

        /// <summary>
        /// list os by description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// list by Os type Id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// list by Os Category id
        /// </summary>
        public Guid OsCategoryId { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

    }
    /// <summary>
    /// Lists all supported OS types for this cloud.
    /// </summary>
    /// <summary>
    /// Lists all supported OS types for this cloud.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<GuestOSResponse> ListOsTypes(ListOsTypesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<GuestOSResponse> ListOsTypes(ListOsTypesRequest request) => _proxy.Request<ListResponse<GuestOSResponse>>(request);
    }
}
