using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DedicateZoneRequest : APIRequest
    {
        public DedicateZoneRequest() : base("dedicateZone") {}

        /// <summary>
        /// the ID of the containing domain
        /// </summary>
        public Guid DomainId {
            get { return GetParameterValue<Guid>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the zone
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

        /// <summary>
        /// the name of the account which needs dedication. Must be used with domainId.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

    }
    /// <summary>
    /// Dedicates a zones.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DedicateZone(DedicateZoneRequest request);
        Task<AsyncJobResponse> DedicateZoneAsync(DedicateZoneRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DedicateZone(DedicateZoneRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DedicateZoneAsync(DedicateZoneRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
