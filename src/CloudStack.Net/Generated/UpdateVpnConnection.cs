using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateVpnConnectionRequest : APIRequest
    {
        public UpdateVpnConnectionRequest() : base("updateVpnConnection") {}

        /// <summary>
        /// id of vpn connection
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId { get; set; }

        /// <summary>
        /// an optional field, whether to the display the vpn to the end user or not
        /// </summary>
        public bool? Display { get; set; }

    }
    /// <summary>
    /// Updates site to site vpn connection
    /// </summary>
    /// <summary>
    /// Updates site to site vpn connection
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        Site2SiteVpnConnectionResponse UpdateVpnConnection(UpdateVpnConnectionRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public Site2SiteVpnConnectionResponse UpdateVpnConnection(UpdateVpnConnectionRequest request) => _proxy.Request<Site2SiteVpnConnectionResponse>(request);
    }
}
