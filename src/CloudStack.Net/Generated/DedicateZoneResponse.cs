using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DedicateZoneResponse
    {
        /// <summary>
        /// the ID of the dedicated resource
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the Account Id to which the Zone is dedicated
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// the Dedication Affinity Group ID of the zone
        /// </summary>
        public string AffinityGroupId { get; set; }

        /// <summary>
        /// the domain ID to which the Zone is dedicated
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// the ID of the Zone
        /// </summary>
        public string ZoneId { get; set; }

        /// <summary>
        /// the Name of the Zone
        /// </summary>
        public string ZoneName { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
