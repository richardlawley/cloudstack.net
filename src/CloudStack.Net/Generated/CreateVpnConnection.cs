using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateVpnConnectionRequest : APIRequest
    {
        public CreateVpnConnectionRequest() : base("createVpnConnection") {}

        /// <summary>
        /// id of the customer gateway
        /// </summary>
        public Guid CustomerGatewayId { get; set; }

        /// <summary>
        /// id of the vpn gateway
        /// </summary>
        public Guid VpnGatewayId { get; set; }

        /// <summary>
        /// an optional field, whether to the display the vpn to the end user or not
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// connection is passive or not
        /// </summary>
        public bool? Passive { get; set; }

    }
    /// <summary>
    /// Create site to site vpn connection
    /// </summary>
    /// <summary>
    /// Create site to site vpn connection
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        Site2SiteVpnConnectionResponse CreateVpnConnection(CreateVpnConnectionRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public Site2SiteVpnConnectionResponse CreateVpnConnection(CreateVpnConnectionRequest request) => _proxy.Request<Site2SiteVpnConnectionResponse>(request);
    }
}
