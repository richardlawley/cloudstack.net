using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListOsCategoriesRequest : APIRequest
    {
        public ListOsCategoriesRequest() : base("listOsCategories") {}

        /// <summary>
        /// list Os category by id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// list os category by name
        /// </summary>
        public string Name { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

    }
    /// <summary>
    /// Lists all supported OS categories for this cloud.
    /// </summary>
    /// <summary>
    /// Lists all supported OS categories for this cloud.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<GuestOSCategoryResponse> ListOsCategories(ListOsCategoriesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<GuestOSCategoryResponse> ListOsCategories(ListOsCategoriesRequest request) => _proxy.Request<ListResponse<GuestOSCategoryResponse>>(request);
    }
}
