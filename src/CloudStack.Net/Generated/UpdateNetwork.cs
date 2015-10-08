using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateNetworkRequest : APIRequest
    {
        public UpdateNetworkRequest() : base("updateNetwork") {}

        /// <summary>
        /// the ID of the network
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Force update even if CIDR type is different
        /// </summary>
        public bool? ChangeCidr { get; set; }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId { get; set; }

        /// <summary>
        /// an optional field, whether to the display the network to the end user or not.
        /// </summary>
        public bool? DisplayNetwork { get; set; }

        /// <summary>
        /// the new display text for the network
        /// </summary>
        public string DisplayText { get; set; }

        /// <summary>
        /// CIDR for guest VMs, CloudStack allocates IPs to guest VMs only from this CIDR
        /// </summary>
        public string GuestVmCidr { get; set; }

        /// <summary>
        /// the new name for the network
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// network domain
        /// </summary>
        public string NetworkDomain { get; set; }

        /// <summary>
        /// network offering ID
        /// </summary>
        public Guid NetworkOfferingId { get; set; }

    }
    /// <summary>
    /// Updates a network
    /// </summary>
    /// <summary>
    /// Updates a network
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        NetworkResponse UpdateNetwork(UpdateNetworkRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public NetworkResponse UpdateNetwork(UpdateNetworkRequest request) => _proxy.Request<NetworkResponse>(request);
    }
}
