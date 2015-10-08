using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ReleaseDedicatedGuestVlanRangeRequest : APIRequest
    {
        public ReleaseDedicatedGuestVlanRangeRequest() : base("releaseDedicatedGuestVlanRange") {}

        /// <summary>
        /// the ID of the dedicated guest vlan range
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Releases a dedicated guest vlan range to the system
    /// </summary>
    /// <summary>
    /// Releases a dedicated guest vlan range to the system
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse ReleaseDedicatedGuestVlanRange(ReleaseDedicatedGuestVlanRangeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse ReleaseDedicatedGuestVlanRange(ReleaseDedicatedGuestVlanRangeRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
