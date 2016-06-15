using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddRegionRequest : APIRequest
    {
        public AddRegionRequest() : base("addRegion") {}

        /// <summary>
        /// Id of the Region
        /// </summary>
        public int? Id {
            get { return GetParameterValue<int?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// Region service endpoint
        /// </summary>
        public string EndPoint {
            get { return GetParameterValue<string>(nameof(EndPoint).ToLower()); }
            set { SetParameterValue(nameof(EndPoint).ToLower(), value); }
        }

        /// <summary>
        /// Name of the region
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

    }
    /// <summary>
    /// Adds a Region
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        RegionResponse AddRegion(AddRegionRequest request);
        Task<RegionResponse> AddRegionAsync(AddRegionRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public RegionResponse AddRegion(AddRegionRequest request) => _proxy.Request<RegionResponse>(request);
        public Task<RegionResponse> AddRegionAsync(AddRegionRequest request) => _proxy.RequestAsync<RegionResponse>(request);
    }
}
