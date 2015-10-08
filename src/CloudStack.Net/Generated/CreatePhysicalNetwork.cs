using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreatePhysicalNetworkRequest : APIRequest
    {
        public CreatePhysicalNetworkRequest() : base("createPhysicalNetwork") {}

        /// <summary>
        /// the name of the physical network
        /// </summary>
        public string NetworkName { get; set; }

        /// <summary>
        /// the Zone ID for the physical network
        /// </summary>
        public Guid ZoneId { get; set; }

        /// <summary>
        /// the broadcast domain range for the physical network[Pod or Zone]. In Acton release it can be Zone only in Advance zone, and Pod in Basic
        /// </summary>
        public string BroadcastDomainRange { get; set; }

        /// <summary>
        /// domain ID of the account owning a physical network
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// the isolation method for the physical network[VLAN/L3/GRE]
        /// </summary>
        public IList<string> IsolationMethods { get; set; }

        /// <summary>
        /// the speed for the physical network[1G/10G]
        /// </summary>
        public string Speed { get; set; }

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
    /// Creates a physical network
    /// </summary>
    /// <summary>
    /// Creates a physical network
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        PhysicalNetworkResponse CreatePhysicalNetwork(CreatePhysicalNetworkRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public PhysicalNetworkResponse CreatePhysicalNetwork(CreatePhysicalNetworkRequest request) => _proxy.Request<PhysicalNetworkResponse>(request);
    }
}
