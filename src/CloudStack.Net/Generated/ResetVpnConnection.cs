using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// an optional account for connection. Must be used with domainId.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// an optional domainId for connection. If the account parameter is used, domainId must also be used.
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Reset site to site vpn connection
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ResetVpnConnection(ResetVpnConnectionRequest request);
        Task<AsyncJobResponse> ResetVpnConnectionAsync(ResetVpnConnectionRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ResetVpnConnection(ResetVpnConnectionRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> ResetVpnConnectionAsync(ResetVpnConnectionRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
