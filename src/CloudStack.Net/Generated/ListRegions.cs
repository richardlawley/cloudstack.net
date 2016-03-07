using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListRegionsRequest : APIListRequest
    {
        public ListRegionsRequest() : base("listRegions") {}

        /// <summary>
        /// List Region by region ID.
        /// </summary>
        public int? Id {
            get { return (int?) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        /// <summary>
        /// List Region by region name.
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists Regions
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<RegionResponse> ListRegions(ListRegionsRequest request);
        Task<ListResponse<RegionResponse>> ListRegionsAsync(ListRegionsRequest request);
        ListResponse<RegionResponse> ListRegionsAllPages(ListRegionsRequest request);
        Task<ListResponse<RegionResponse>> ListRegionsAllPagesAsync(ListRegionsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<RegionResponse> ListRegions(ListRegionsRequest request) => _proxy.Request<ListResponse<RegionResponse>>(request);
        public Task<ListResponse<RegionResponse>> ListRegionsAsync(ListRegionsRequest request) => _proxy.RequestAsync<ListResponse<RegionResponse>>(request);
        public ListResponse<RegionResponse> ListRegionsAllPages(ListRegionsRequest request) => _proxy.RequestAllPages<RegionResponse>(request);
        public Task<ListResponse<RegionResponse>> ListRegionsAllPagesAsync(ListRegionsRequest request) => _proxy.RequestAllPagesAsync<RegionResponse>(request);
    }
}
