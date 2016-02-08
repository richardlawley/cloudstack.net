using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ProviderResponse
    {
        /// <summary>
        /// uuid of the network provider
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// true if individual services can be enabled/disabled
        /// </summary>
        public bool Canenableindividualservice { get; set; }

        /// <summary>
        /// the destination physical network
        /// </summary>
        public string DestinationPhysicalNetworkId { get; set; }

        /// <summary>
        /// the provider name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the physical network this belongs to
        /// </summary>
        public string PhysicalNetworkId { get; set; }

        /// <summary>
        /// services for this provider
        /// </summary>
        public IList<string> Servicelist { get; set; }

        /// <summary>
        /// state of the network provider
        /// </summary>
        public string State { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
