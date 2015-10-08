using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListRegionsRequest : APIRequest
    {
        public ListRegionsRequest() : base("listRegions") {}

        /// <summary>
        /// List Region by region ID.
        /// </summary>
        public int? Id { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// List Region by region name.
        /// </summary>
        public string Name { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

    }
    /// <summary>
    /// Lists Regions
    /// </summary>
    /// <summary>
    /// Lists Regions
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<RegionResponse> ListRegions(ListRegionsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<RegionResponse> ListRegions(ListRegionsRequest request) => _proxy.Request<ListResponse<RegionResponse>>(request);
    }
}
