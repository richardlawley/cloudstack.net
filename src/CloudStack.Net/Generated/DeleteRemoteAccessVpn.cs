using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteRemoteAccessVpnRequest : APIRequest
    {
        public DeleteRemoteAccessVpnRequest() : base("deleteRemoteAccessVpn") {}

        /// <summary>
        /// public ip address id of the vpn server
        /// </summary>
        public Guid PublicIpId {
            get { return (Guid) Parameters[nameof(PublicIpId).ToLower()]; }
            set { Parameters[nameof(PublicIpId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Destroys a l2tp/ipsec remote access vpn
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteRemoteAccessVpn(DeleteRemoteAccessVpnRequest request);
        Task<AsyncJobResponse> DeleteRemoteAccessVpnAsync(DeleteRemoteAccessVpnRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteRemoteAccessVpn(DeleteRemoteAccessVpnRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteRemoteAccessVpnAsync(DeleteRemoteAccessVpnRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
