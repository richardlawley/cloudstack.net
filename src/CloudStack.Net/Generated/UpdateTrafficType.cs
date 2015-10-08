using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateTrafficTypeRequest : APIRequest
    {
        public UpdateTrafficTypeRequest() : base("updateTrafficType") {}

        /// <summary>
        /// traffic type id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The network name label of the physical device dedicated to this traffic on a Hyperv host
        /// </summary>
        public string HypervLabel { get; set; }

        /// <summary>
        /// The network name label of the physical device dedicated to this traffic on a KVM host
        /// </summary>
        public string KvmLabel { get; set; }

        /// <summary>
        /// The network name of the physical device dedicated to this traffic on an OVM3 host
        /// </summary>
        public string Ovm3Label { get; set; }

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
    /// Updates traffic type of a physical network
    /// </summary>
    /// <summary>
    /// Updates traffic type of a physical network
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        TrafficTypeResponse UpdateTrafficType(UpdateTrafficTypeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public TrafficTypeResponse UpdateTrafficType(UpdateTrafficTypeRequest request) => _proxy.Request<TrafficTypeResponse>(request);
    }
}
