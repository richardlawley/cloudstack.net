using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class TrafficTypeResponse
    {
        /// <summary>
        /// id of the network provider
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The network name label of the physical device dedicated to this traffic on a HyperV host
        /// </summary>
        public string HypervNetworkLabel { get; set; }

        /// <summary>
        /// The network name label of the physical device dedicated to this traffic on a KVM host
        /// </summary>
        public string KvmNetworkLabel { get; set; }

        /// <summary>
        /// The network name of the physical device dedicated to this traffic on an OVM3 host
        /// </summary>
        public string Ovm3NetworkLabel { get; set; }

        /// <summary>
        /// the physical network this belongs to
        /// </summary>
        public string PhysicalNetworkId { get; set; }

        /// <summary>
        /// the trafficType to be added to the physical network
        /// </summary>
        public string TrafficType { get; set; }

        /// <summary>
        /// The network name label of the physical device dedicated to this traffic on a VMware host
        /// </summary>
        public string VmwareNetworkLabel { get; set; }

        /// <summary>
        /// The network name label of the physical device dedicated to this traffic on a XenServer host
        /// </summary>
        public string XenNetworkLabel { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
