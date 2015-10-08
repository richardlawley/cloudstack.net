using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateZoneRequest : APIRequest
    {
        public CreateZoneRequest() : base("createZone") {}

        /// <summary>
        /// the first DNS for the Zone
        /// </summary>
        public string Dns1 { get; set; }

        /// <summary>
        /// the first internal DNS for the Zone
        /// </summary>
        public string InternalDns1 { get; set; }

        /// <summary>
        /// the name of the Zone
        /// </summary>
        public string ZoneName { get; set; }

        /// <summary>
        /// network type of the zone, can be Basic or Advanced
        /// </summary>
        public string NetworkType { get; set; }

        /// <summary>
        /// Allocation state of this Zone for allocation of new resources
        /// </summary>
        public string AllocationState { get; set; }

        /// <summary>
        /// the second DNS for the Zone
        /// </summary>
        public string Dns2 { get; set; }

        /// <summary>
        /// Network domain name for the networks in the zone
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the ID of the containing domain, null for public zones
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// the guest CIDR address for the Zone
        /// </summary>
        public string GuestCidrAddress { get; set; }

        /// <summary>
        /// the second internal DNS for the Zone
        /// </summary>
        public string InternalDns2 { get; set; }

        /// <summary>
        /// the first DNS for IPv6 network in the Zone
        /// </summary>
        public string Ip6Dns1 { get; set; }

        /// <summary>
        /// the second DNS for IPv6 network in the Zone
        /// </summary>
        public string Ip6Dns2 { get; set; }

        /// <summary>
        /// true if local storage offering enabled, false otherwise
        /// </summary>
        public bool? LocalStorageEnabled { get; set; }

        /// <summary>
        /// true if network is security group enabled, false otherwise
        /// </summary>
        public bool? Securitygroupenabled { get; set; }

    }
    /// <summary>
    /// Creates a Zone.
    /// </summary>
    /// <summary>
    /// Creates a Zone.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ZoneResponse CreateZone(CreateZoneRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ZoneResponse CreateZone(CreateZoneRequest request) => _proxy.Request<ZoneResponse>(request);
    }
}
