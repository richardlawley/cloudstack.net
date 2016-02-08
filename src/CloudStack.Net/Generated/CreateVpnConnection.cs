using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateVpnConnectionRequest : APIRequest
    {
        public CreateVpnConnectionRequest() : base("createVpnConnection") {}

        /// <summary>
        /// id of the customer gateway
        /// </summary>
        public Guid S2scustomergatewayid {
            get { return (Guid) Parameters[nameof(S2scustomergatewayid).ToLower()]; }
            set { Parameters[nameof(S2scustomergatewayid).ToLower()] = value; }
        }

        /// <summary>
        /// id of the vpn gateway
        /// </summary>
        public Guid S2svpngatewayid {
            get { return (Guid) Parameters[nameof(S2svpngatewayid).ToLower()]; }
            set { Parameters[nameof(S2svpngatewayid).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, whether to the display the vpn to the end user or not
        /// </summary>
        public bool? Fordisplay {
            get { return (bool?) Parameters[nameof(Fordisplay).ToLower()]; }
            set { Parameters[nameof(Fordisplay).ToLower()] = value; }
        }

        /// <summary>
        /// connection is passive or not
        /// </summary>
        public bool? Passive {
            get { return (bool?) Parameters[nameof(Passive).ToLower()]; }
            set { Parameters[nameof(Passive).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Create site to site vpn connection
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateVpnConnection(CreateVpnConnectionRequest request);
        Task<AsyncJobResponse> CreateVpnConnectionAsync(CreateVpnConnectionRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateVpnConnection(CreateVpnConnectionRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateVpnConnectionAsync(CreateVpnConnectionRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
