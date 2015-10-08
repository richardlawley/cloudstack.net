using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateRegionRequest : APIRequest
    {
        public UpdateRegionRequest() : base("updateRegion") {}

        /// <summary>
        /// Id of region to update
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// updates region with this end point
        /// </summary>
        public string EndPoint { get; set; }

        /// <summary>
        /// updates region with this name
        /// </summary>
        public string RegionName { get; set; }

    }
    /// <summary>
    /// Updates a region
    /// </summary>
    /// <summary>
    /// Updates a region
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        RegionResponse UpdateRegion(UpdateRegionRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public RegionResponse UpdateRegion(UpdateRegionRequest request) => _proxy.Request<RegionResponse>(request);
    }
}
