using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteRemoteAccessVpnRequest : APIRequest
    {
        public DeleteRemoteAccessVpnRequest() : base("deleteRemoteAccessVpn") {}

        /// <summary>
        /// public ip address id of the vpn server
        /// </summary>
        public Guid PublicIpId { get; set; }

    }
    /// <summary>
    /// Destroys a l2tp/ipsec remote access vpn
    /// </summary>
    /// <summary>
    /// Destroys a l2tp/ipsec remote access vpn
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteRemoteAccessVpn(DeleteRemoteAccessVpnRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteRemoteAccessVpn(DeleteRemoteAccessVpnRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
