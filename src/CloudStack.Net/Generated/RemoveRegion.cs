using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RemoveRegionRequest : APIRequest
    {
        public RemoveRegionRequest() : base("removeRegion") {}

        /// <summary>
        /// ID of the region to delete
        /// </summary>
        public int? Id {
            get { return GetParameterValue<int?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Removes specified region
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse RemoveRegion(RemoveRegionRequest request);
        Task<SuccessResponse> RemoveRegionAsync(RemoveRegionRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse RemoveRegion(RemoveRegionRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> RemoveRegionAsync(RemoveRegionRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
