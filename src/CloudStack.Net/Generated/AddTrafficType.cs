using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddTrafficTypeRequest : APIRequest
    {
        public AddTrafficTypeRequest() : base("addTrafficType") {}

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId { get; set; }

        /// <summary>
        /// the trafficType to be added to the physical network
        /// </summary>
        public string TrafficType { get; set; }

        /// <summary>
        /// The network name label of the physical device dedicated to this traffic on a Hyperv host
        /// </summary>
        public string HypervLabel { get; set; }

        /// <summary>
        /// Used if physical network has multiple isolation types and traffic type is public. Choose which isolation method. Valid options currently 'vlan' or 'vxlan', defaults to 'vlan'.
        /// </summary>
        public string IsolationMethod { get; set; }

        /// <summary>
        /// The network name label of the physical device dedicated to this traffic on a KVM host
        /// </summary>
        public string KvmLabel { get; set; }

        /// <summary>
        /// The network name of the physical device dedicated to this traffic on an OVM3 host
        /// </summary>
        public string Ovm3Label { get; set; }

        /// <summary>
        /// The VLAN id to be used for Management traffic by VMware host
        /// </summary>
        public string Vlan { get; set; }

        /// <summary>
        /// The network name label of the physical device dedicated to this traffic on a VMware host
        /// </summary>
        public string VmwareLabel { get; set; }

        /// <summary>
        /// The network name label of the physical device dedicated to this traffic on a XenServer host
        /// </summary>
        public string XenLabel { get; set; }

    }
    /// <summary>
    /// Adds traffic type to a physical network
    /// </summary>
    /// <summary>
    /// Adds traffic type to a physical network
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        TrafficTypeResponse AddTrafficType(AddTrafficTypeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public TrafficTypeResponse AddTrafficType(AddTrafficTypeRequest request) => _proxy.Request<TrafficTypeResponse>(request);
    }
}
