using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListAffinityGroupTypesRequest : APIListRequest
    {
        public ListAffinityGroupTypesRequest() : base("listAffinityGroupTypes") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists affinity group types available
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<AffinityGroupTypeResponse> ListAffinityGroupTypes(ListAffinityGroupTypesRequest request);
        Task<ListResponse<AffinityGroupTypeResponse>> ListAffinityGroupTypesAsync(ListAffinityGroupTypesRequest request);
        ListResponse<AffinityGroupTypeResponse> ListAffinityGroupTypesAllPages(ListAffinityGroupTypesRequest request);
        Task<ListResponse<AffinityGroupTypeResponse>> ListAffinityGroupTypesAllPagesAsync(ListAffinityGroupTypesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<AffinityGroupTypeResponse> ListAffinityGroupTypes(ListAffinityGroupTypesRequest request) => _proxy.Request<ListResponse<AffinityGroupTypeResponse>>(request);
        public Task<ListResponse<AffinityGroupTypeResponse>> ListAffinityGroupTypesAsync(ListAffinityGroupTypesRequest request) => _proxy.RequestAsync<ListResponse<AffinityGroupTypeResponse>>(request);
        public ListResponse<AffinityGroupTypeResponse> ListAffinityGroupTypesAllPages(ListAffinityGroupTypesRequest request) => _proxy.RequestAllPages<AffinityGroupTypeResponse>(request);
        public Task<ListResponse<AffinityGroupTypeResponse>> ListAffinityGroupTypesAllPagesAsync(ListAffinityGroupTypesRequest request) => _proxy.RequestAllPagesAsync<AffinityGroupTypeResponse>(request);
    }
}
