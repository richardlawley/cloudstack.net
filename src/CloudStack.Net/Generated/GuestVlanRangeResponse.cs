using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class GuestVlanRangeResponse
    {
        /// <summary>
        /// the ID of the guest VLAN range
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the account of the guest VLAN range
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// the domain name of the guest VLAN range
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the domain ID of the guest VLAN range
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// the guest VLAN range
        /// </summary>
        public string GuestVlanRange { get; set; }

        /// <summary>
        /// the physical network of the guest vlan range
        /// </summary>
        public long PhysicalNetworkId { get; set; }

        /// <summary>
        /// the project name of the guest vlan range
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// the project id of the guest vlan range
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// the zone of the guest vlan range
        /// </summary>
        public long ZoneId { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
