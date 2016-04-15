using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListUcsProfilesRequest : APIListRequest
    {
        public ListUcsProfilesRequest() : base("listUcsProfiles") {}

        /// <summary>
        /// the id for the ucs manager
        /// </summary>
        public Guid UcsManagerId {
            get { return GetParameterValue<Guid>(nameof(UcsManagerId).ToLower()); }
            set { SetParameterValue(nameof(UcsManagerId).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

    }
    /// <summary>
    /// List profile in ucs manager
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<UcsProfileResponse> ListUcsProfiles(ListUcsProfilesRequest request);
        Task<ListResponse<UcsProfileResponse>> ListUcsProfilesAsync(ListUcsProfilesRequest request);
        ListResponse<UcsProfileResponse> ListUcsProfilesAllPages(ListUcsProfilesRequest request);
        Task<ListResponse<UcsProfileResponse>> ListUcsProfilesAllPagesAsync(ListUcsProfilesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<UcsProfileResponse> ListUcsProfiles(ListUcsProfilesRequest request) => _proxy.Request<ListResponse<UcsProfileResponse>>(request);
        public Task<ListResponse<UcsProfileResponse>> ListUcsProfilesAsync(ListUcsProfilesRequest request) => _proxy.RequestAsync<ListResponse<UcsProfileResponse>>(request);
        public ListResponse<UcsProfileResponse> ListUcsProfilesAllPages(ListUcsProfilesRequest request) => _proxy.RequestAllPages<UcsProfileResponse>(request);
        public Task<ListResponse<UcsProfileResponse>> ListUcsProfilesAllPagesAsync(ListUcsProfilesRequest request) => _proxy.RequestAllPagesAsync<UcsProfileResponse>(request);
    }
}
