using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateVpnGatewayRequest : APIRequest
    {
        public UpdateVpnGatewayRequest() : base("updateVpnGateway") {}

        /// <summary>
        /// id of customer gateway
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId {
            get { return (string) Parameters[nameof(CustomId).ToLower()]; }
            set { Parameters[nameof(CustomId).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, whether to the display the vpn to the end user or not
        /// </summary>
        public bool? Fordisplay {
            get { return (bool?) Parameters[nameof(Fordisplay).ToLower()]; }
            set { Parameters[nameof(Fordisplay).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Updates site to site vpn local gateway
    /// </summary>
    /// <summary>
    /// Updates site to site vpn local gateway
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        Site2SiteVpnGatewayResponse UpdateVpnGateway(UpdateVpnGatewayRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public Site2SiteVpnGatewayResponse UpdateVpnGateway(UpdateVpnGatewayRequest request) => _proxy.Request<Site2SiteVpnGatewayResponse>(request);
    }
}
