using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class PhysicalNetworkResponse
    {
        /// <summary>
        /// the uuid of the physical network
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Broadcast domain range of the physical network
        /// </summary>
        public string BroadcastDomainRange { get; set; }

        /// <summary>
        /// the domain id of the physical network owner
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// isolation methods
        /// </summary>
        public string IsolationMethods { get; set; }

        /// <summary>
        /// name of the physical network
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the speed of the physical network
        /// </summary>
        public string NetworkSpeed { get; set; }

        /// <summary>
        /// state of the physical network
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// comma separated tag
        /// </summary>
        public string Tags { get; set; }

        /// <summary>
        /// the vlan of the physical network
        /// </summary>
        public string Vlan { get; set; }

        /// <summary>
        /// zone id of the physical network
        /// </summary>
        public string ZoneId { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
