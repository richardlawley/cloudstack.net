using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class NetworkOfferingResponse
    {
        /// <summary>
        /// the id of the network offering
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// availability of the network offering
        /// </summary>
        public string Availability { get; set; }

        /// <summary>
        /// true if network offering is ip conserve mode enabled
        /// </summary>
        public bool ConserveMode { get; set; }

        /// <summary>
        /// the date this network offering was created
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// additional key/value details tied with network offering
        /// </summary>
        public IList<IDictionary<string, object>> Details { get; set; }

        /// <summary>
        /// an alternate display text of the network offering.
        /// </summary>
        public string DisplayText { get; set; }

        /// <summary>
        /// true if guest network default egress policy is allow; false if default egress policy is deny
        /// </summary>
        public bool EgressDefaultPolicy { get; set; }

        /// <summary>
        /// true if network offering can be used by VPC networks only
        /// </summary>
        public bool ForVpc { get; set; }

        /// <summary>
        /// guest type of the network offering, can be Shared or Isolated
        /// </summary>
        public string GuestIpType { get; set; }

        /// <summary>
        /// true if network offering is default, false otherwise
        /// </summary>
        public bool IsDefault { get; set; }

        /// <summary>
        /// true if network offering supports persistent networks, false otherwise
        /// </summary>
        public bool IsPersistent { get; set; }

        /// <summary>
        /// maximum number of concurrents connections to be handled by lb
        /// </summary>
        public int Maxconnections { get; set; }

        /// <summary>
        /// the name of the network offering
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// data transfer rate in megabits per second allowed.
        /// </summary>
        public int NetworkRate { get; set; }

        /// <summary>
        /// the ID of the service offering used by virtual router provider
        /// </summary>
        public string ServiceOfferingId { get; set; }

        /// <summary>
        /// true if network offering supports specifying ip ranges, false otherwise
        /// </summary>
        public bool SpecifyIpRanges { get; set; }

        /// <summary>
        /// true if network offering supports vlans, false otherwise
        /// </summary>
        public bool SpecifyVlan { get; set; }

        /// <summary>
        /// state of the network offering. Can be Disabled/Enabled/Inactive
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// true if network offering supports network that span multiple zones
        /// </summary>
        public bool SupportsStrechedL2Subnet { get; set; }

        /// <summary>
        /// the tags for the network offering
        /// </summary>
        public string Tags { get; set; }

        /// <summary>
        /// the traffic type for the network offering, supported types are Public, Management, Control, Guest, Vlan or Storage.
        /// </summary>
        public string TrafficType { get; set; }

        /// <summary>
        /// the list of supported services
        /// </summary>
        public IList<ServiceResponse> Service { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
