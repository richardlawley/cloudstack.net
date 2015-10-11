using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteVpnConnectionRequest : APIRequest
    {
        public DeleteVpnConnectionRequest() : base("deleteVpnConnection") {}

        /// <summary>
        /// id of vpn connection
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Delete site to site vpn connection
    /// </summary>
    /// <summary>
    /// Delete site to site vpn connection
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteVpnConnection(DeleteVpnConnectionRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteVpnConnection(DeleteVpnConnectionRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
