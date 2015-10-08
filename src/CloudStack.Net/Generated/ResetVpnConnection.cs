using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ResetVpnConnectionRequest : APIRequest
    {
        public ResetVpnConnectionRequest() : base("resetVpnConnection") {}

        /// <summary>
        /// id of vpn connection
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// an optional account for connection. Must be used with domainId.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// an optional domainId for connection. If the account parameter is used, domainId must also be used.
        /// </summary>
        public Guid DomainId { get; set; }

    }
    /// <summary>
    /// Reset site to site vpn connection
    /// </summary>
    /// <summary>
    /// Reset site to site vpn connection
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        Site2SiteVpnConnectionResponse ResetVpnConnection(ResetVpnConnectionRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public Site2SiteVpnConnectionResponse ResetVpnConnection(ResetVpnConnectionRequest request) => _proxy.Request<Site2SiteVpnConnectionResponse>(request);
    }
}
