using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ReleaseDedicatedZoneRequest : APIRequest
    {
        public ReleaseDedicatedZoneRequest() : base("releaseDedicatedZone") {}

        /// <summary>
        /// the ID of the Zone
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Release dedication of zone
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ReleaseDedicatedZone(ReleaseDedicatedZoneRequest request);
        Task<AsyncJobResponse> ReleaseDedicatedZoneAsync(ReleaseDedicatedZoneRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ReleaseDedicatedZone(ReleaseDedicatedZoneRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> ReleaseDedicatedZoneAsync(ReleaseDedicatedZoneRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
