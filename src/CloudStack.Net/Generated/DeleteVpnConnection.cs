using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Delete site to site vpn connection
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteVpnConnection(DeleteVpnConnectionRequest request);
        Task<AsyncJobResponse> DeleteVpnConnectionAsync(DeleteVpnConnectionRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteVpnConnection(DeleteVpnConnectionRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteVpnConnectionAsync(DeleteVpnConnectionRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
