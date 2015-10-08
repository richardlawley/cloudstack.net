using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateRemoteAccessVpnRequest : APIRequest
    {
        public UpdateRemoteAccessVpnRequest() : base("updateRemoteAccessVpn") {}

        /// <summary>
        /// id of the remote access vpn
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
    /// Updates remote access vpn
    /// </summary>
    /// <summary>
    /// Updates remote access vpn
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        RemoteAccessVpnResponse UpdateRemoteAccessVpn(UpdateRemoteAccessVpnRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public RemoteAccessVpnResponse UpdateRemoteAccessVpn(UpdateRemoteAccessVpnRequest request) => _proxy.Request<RemoteAccessVpnResponse>(request);
    }
}
