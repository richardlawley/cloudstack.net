using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddRegionRequest : APIRequest
    {
        public AddRegionRequest() : base("addRegion") {}

        /// <summary>
        /// Id of the Region
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Region service endpoint
        /// </summary>
        public string EndPoint { get; set; }

        /// <summary>
        /// Name of the region
        /// </summary>
        public string RegionName { get; set; }

    }
    /// <summary>
    /// Adds a Region
    /// </summary>
    /// <summary>
    /// Adds a Region
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        RegionResponse AddRegion(AddRegionRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public RegionResponse AddRegion(AddRegionRequest request) => _proxy.Request<RegionResponse>(request);
    }
}
