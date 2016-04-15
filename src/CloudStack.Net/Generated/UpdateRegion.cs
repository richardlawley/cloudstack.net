using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateRegionRequest : APIRequest
    {
        public UpdateRegionRequest() : base("updateRegion") {}

        /// <summary>
        /// Id of region to update
        /// </summary>
        public int Id {
            get { return GetParameterValue<int>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// updates region with this end point
        /// </summary>
        public string EndPoint {
            get { return GetParameterValue<string>(nameof(EndPoint).ToLower()); }
            set { SetParameterValue(nameof(EndPoint).ToLower(), value); }
        }

        /// <summary>
        /// updates region with this name
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates a region
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        RegionResponse UpdateRegion(UpdateRegionRequest request);
        Task<RegionResponse> UpdateRegionAsync(UpdateRegionRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public RegionResponse UpdateRegion(UpdateRegionRequest request) => _proxy.Request<RegionResponse>(request);
        public Task<RegionResponse> UpdateRegionAsync(UpdateRegionRequest request) => _proxy.RequestAsync<RegionResponse>(request);
    }
}
