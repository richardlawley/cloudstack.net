using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DedicateGuestVlanRangeRequest : APIRequest
    {
        public DedicateGuestVlanRangeRequest() : base("dedicateGuestVlanRange") {}

        /// <summary>
        /// account who will own the VLAN
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// domain ID of the account owning a VLAN
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// physical network ID of the vlan
        /// </summary>
        public Guid PhysicalNetworkId { get; set; }

        /// <summary>
        /// guest vlan range to be dedicated
        /// </summary>
        public string Vlan { get; set; }

        /// <summary>
        /// project who will own the VLAN
        /// </summary>
        public Guid ProjectId { get; set; }

    }
    /// <summary>
    /// Dedicates a guest vlan range to an account
    /// </summary>
    /// <summary>
    /// Dedicates a guest vlan range to an account
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        GuestVlanRangeResponse DedicateGuestVlanRange(DedicateGuestVlanRangeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public GuestVlanRangeResponse DedicateGuestVlanRange(DedicateGuestVlanRangeRequest request) => _proxy.Request<GuestVlanRangeResponse>(request);
    }
}
