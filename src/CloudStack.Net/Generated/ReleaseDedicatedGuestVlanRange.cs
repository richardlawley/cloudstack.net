using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ReleaseDedicatedGuestVlanRangeRequest : APIRequest
    {
        public ReleaseDedicatedGuestVlanRangeRequest() : base("releaseDedicatedGuestVlanRange") {}

        /// <summary>
        /// the ID of the dedicated guest vlan range
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Releases a dedicated guest vlan range to the system
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ReleaseDedicatedGuestVlanRange(ReleaseDedicatedGuestVlanRangeRequest request);
        Task<AsyncJobResponse> ReleaseDedicatedGuestVlanRangeAsync(ReleaseDedicatedGuestVlanRangeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ReleaseDedicatedGuestVlanRange(ReleaseDedicatedGuestVlanRangeRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> ReleaseDedicatedGuestVlanRangeAsync(ReleaseDedicatedGuestVlanRangeRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
