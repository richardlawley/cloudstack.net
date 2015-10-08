using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ZoneResponse
    {
        /// <summary>
        /// Zone id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the allocation state of the cluster
        /// </summary>
        public string AllocationState { get; set; }

        /// <summary>
        /// Zone description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// the dhcp Provider for the Zone
        /// </summary>
        public string DhcpProvider { get; set; }

        /// <summary>
        /// the display text of the zone
        /// </summary>
        public string DisplayText { get; set; }

        /// <summary>
        /// the first DNS for the Zone
        /// </summary>
        public string Dns1 { get; set; }

        /// <summary>
        /// the second DNS for the Zone
        /// </summary>
        public string Dns2 { get; set; }

        /// <summary>
        /// Network domain name for the networks in the zone
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the UUID of the containing domain, null for public zones
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// the name of the containing domain, null for public zones
        /// </summary>
        public string DomainName { get; set; }

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
        /// the first IPv6 DNS for the Zone
        /// </summary>
        public string Ip6Dns1 { get; set; }

        /// <summary>
        /// the second IPv6 DNS for the Zone
        /// </summary>
        public string Ip6Dns2 { get; set; }

        /// <summary>
        /// true if local storage offering enabled, false otherwise
        /// </summary>
        public bool LocalStorageEnabled { get; set; }

        /// <summary>
        /// Zone name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the network type of the zone; can be Basic or Advanced
        /// </summary>
        public string NetworkType { get; set; }

        /// <summary>
        /// Meta data associated with the zone (key/value pairs)
        /// </summary>
        public IDictionary<string, string> ResourceDetails { get; set; }

        /// <summary>
        /// true if security groups support is enabled, false otherwise
        /// </summary>
        public bool SecurityGroupsEnabled { get; set; }

        /// <summary>
        /// Zone Token
        /// </summary>
        public string ZoneToken { get; set; }

        /// <summary>
        /// the capacity of the Zone
        /// </summary>
        public IList<CapacityResponse> Capacity { get; set; }

        /// <summary>
        /// the list of resource tags associated with zone.
        /// </summary>
        public IList<ResourceTagResponse> Tags { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
