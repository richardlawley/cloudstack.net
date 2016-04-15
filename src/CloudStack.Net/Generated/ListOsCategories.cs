using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListOsCategoriesRequest : APIListRequest
    {
        public ListOsCategoriesRequest() : base("listOsCategories") {}

        /// <summary>
        /// list Os category by id
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// list os category by name
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists all supported OS categories for this cloud.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<GuestOSCategoryResponse> ListOsCategories(ListOsCategoriesRequest request);
        Task<ListResponse<GuestOSCategoryResponse>> ListOsCategoriesAsync(ListOsCategoriesRequest request);
        ListResponse<GuestOSCategoryResponse> ListOsCategoriesAllPages(ListOsCategoriesRequest request);
        Task<ListResponse<GuestOSCategoryResponse>> ListOsCategoriesAllPagesAsync(ListOsCategoriesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<GuestOSCategoryResponse> ListOsCategories(ListOsCategoriesRequest request) => _proxy.Request<ListResponse<GuestOSCategoryResponse>>(request);
        public Task<ListResponse<GuestOSCategoryResponse>> ListOsCategoriesAsync(ListOsCategoriesRequest request) => _proxy.RequestAsync<ListResponse<GuestOSCategoryResponse>>(request);
        public ListResponse<GuestOSCategoryResponse> ListOsCategoriesAllPages(ListOsCategoriesRequest request) => _proxy.RequestAllPages<GuestOSCategoryResponse>(request);
        public Task<ListResponse<GuestOSCategoryResponse>> ListOsCategoriesAllPagesAsync(ListOsCategoriesRequest request) => _proxy.RequestAllPagesAsync<GuestOSCategoryResponse>(request);
    }
}
