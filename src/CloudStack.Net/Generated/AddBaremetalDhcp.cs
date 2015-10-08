using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddBaremetalDhcpRequest : APIRequest
    {
        public AddBaremetalDhcpRequest() : base("addBaremetalDhcp") {}

        /// <summary>
        /// Type of dhcp device
        /// </summary>
        public string DhcpType { get; set; }

        /// <summary>
        /// Credentials to reach external dhcp device
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId { get; set; }

        /// <summary>
        /// URL of the external dhcp appliance.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Credentials to reach external dhcp device
        /// </summary>
        public string Username { get; set; }

    }
    /// <summary>
    /// adds a baremetal dhcp server
    /// </summary>
    /// <summary>
    /// adds a baremetal dhcp server
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        BaremetalDhcpResponse AddBaremetalDhcp(AddBaremetalDhcpRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public BaremetalDhcpResponse AddBaremetalDhcp(AddBaremetalDhcpRequest request) => _proxy.Request<BaremetalDhcpResponse>(request);
    }
}
