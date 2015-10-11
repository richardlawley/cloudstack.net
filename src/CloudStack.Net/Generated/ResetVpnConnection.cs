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
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// an optional account for connection. Must be used with domainId.
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// an optional domainId for connection. If the account parameter is used, domainId must also be used.
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Reset site to site vpn connection
    /// </summary>
    /// <summary>
    /// Reset site to site vpn connection
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ResetVpnConnection(ResetVpnConnectionRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ResetVpnConnection(ResetVpnConnectionRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
