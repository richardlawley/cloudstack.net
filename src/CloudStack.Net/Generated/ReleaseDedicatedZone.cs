using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Release dedication of zone
    /// </summary>
    /// <summary>
    /// Release dedication of zone
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ReleaseDedicatedZone(ReleaseDedicatedZoneRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ReleaseDedicatedZone(ReleaseDedicatedZoneRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
