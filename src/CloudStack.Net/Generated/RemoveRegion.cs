using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RemoveRegionRequest : APIRequest
    {
        public RemoveRegionRequest() : base("removeRegion") {}

        /// <summary>
        /// ID of the region to delete
        /// </summary>
        public int Id {
            get { return (int) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Removes specified region
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse RemoveRegion(RemoveRegionRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse RemoveRegion(RemoveRegionRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
