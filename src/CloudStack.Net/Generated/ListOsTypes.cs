using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListOsTypesRequest : APIListRequest
    {
        public ListOsTypesRequest() : base("listOsTypes") {}

        /// <summary>
        /// list os by description
        /// </summary>
        public string Description {
            get { return GetParameterValue<string>(nameof(Description).ToLower()); }
            set { SetParameterValue(nameof(Description).ToLower(), value); }
        }

        /// <summary>
        /// list by Os type Id
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
        /// list by Os Category id
        /// </summary>
        public Guid OsCategoryId {
            get { return GetParameterValue<Guid>(nameof(OsCategoryId).ToLower()); }
            set { SetParameterValue(nameof(OsCategoryId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists all supported OS types for this cloud.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<GuestOSResponse> ListOsTypes(ListOsTypesRequest request);
        Task<ListResponse<GuestOSResponse>> ListOsTypesAsync(ListOsTypesRequest request);
        ListResponse<GuestOSResponse> ListOsTypesAllPages(ListOsTypesRequest request);
        Task<ListResponse<GuestOSResponse>> ListOsTypesAllPagesAsync(ListOsTypesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<GuestOSResponse> ListOsTypes(ListOsTypesRequest request) => _proxy.Request<ListResponse<GuestOSResponse>>(request);
        public Task<ListResponse<GuestOSResponse>> ListOsTypesAsync(ListOsTypesRequest request) => _proxy.RequestAsync<ListResponse<GuestOSResponse>>(request);
        public ListResponse<GuestOSResponse> ListOsTypesAllPages(ListOsTypesRequest request) => _proxy.RequestAllPages<GuestOSResponse>(request);
        public Task<ListResponse<GuestOSResponse>> ListOsTypesAllPagesAsync(ListOsTypesRequest request) => _proxy.RequestAllPagesAsync<GuestOSResponse>(request);
    }
}
