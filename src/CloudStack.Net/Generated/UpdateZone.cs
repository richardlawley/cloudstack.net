using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateZoneRequest : APIRequest
    {
        public UpdateZoneRequest() : base("updateZone") {}

        /// <summary>
        /// the ID of the Zone
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Allocation state of this cluster for allocation of new resources
        /// </summary>
        public string AllocationState { get; set; }

        /// <summary>
        /// the details for the Zone
        /// </summary>
        public IDictionary<string, string> Details { get; set; }

        /// <summary>
        /// the dhcp Provider for the Zone
        /// </summary>
        public string DhcpProvider { get; set; }

        /// <summary>
        /// the first DNS for the Zone
        /// </summary>
        public string Dns1 { get; set; }

        /// <summary>
        /// the second DNS for the Zone
        /// </summary>
        public string Dns2 { get; set; }

        /// <summary>
        /// the dns search order list
        /// </summary>
        public IList<string> DnsSearchOrder { get; set; }

        /// <summary>
        /// Network domain name for the networks in the zone; empty string will update domain with NULL value
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the guest CIDR address for the Zone
        /// </summary>
        public string GuestCidrAddress { get; set; }

        /// <summary>
        /// the first internal DNS for the Zone
        /// </summary>
        public string InternalDns1 { get; set; }

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
        /// updates a private zone to public if set, but not vice-versa
        /// </summary>
        public bool? IsPublic { get; set; }

        /// <summary>
        /// true if local storage offering enabled, false otherwise
        /// </summary>
        public bool? LocalStorageEnabled { get; set; }

        /// <summary>
        /// the name of the Zone
        /// </summary>
        public string ZoneName { get; set; }

    }
    /// <summary>
    /// Updates a Zone.
    /// </summary>
    /// <summary>
    /// Updates a Zone.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ZoneResponse UpdateZone(UpdateZoneRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ZoneResponse UpdateZone(UpdateZoneRequest request) => _proxy.Request<ZoneResponse>(request);
    }
}
