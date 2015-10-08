using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdatePhysicalNetworkRequest : APIRequest
    {
        public UpdatePhysicalNetworkRequest() : base("updatePhysicalNetwork") {}

        /// <summary>
        /// physical network id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// the speed for the physical network[1G/10G]
        /// </summary>
        public string Speed { get; set; }

        /// <summary>
        /// Enabled/Disabled
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Tag the physical network
        /// </summary>
        public IList<string> Tags { get; set; }

        /// <summary>
        /// the VLAN for the physical network
        /// </summary>
        public string Vlan { get; set; }

    }
    /// <summary>
    /// Updates a physical network
    /// </summary>
    /// <summary>
    /// Updates a physical network
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        PhysicalNetworkResponse UpdatePhysicalNetwork(UpdatePhysicalNetworkRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public PhysicalNetworkResponse UpdatePhysicalNetwork(UpdatePhysicalNetworkRequest request) => _proxy.Request<PhysicalNetworkResponse>(request);
    }
}
