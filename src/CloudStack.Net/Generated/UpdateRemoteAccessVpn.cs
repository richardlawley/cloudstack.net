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
    /// Updates remote access vpn
    /// </summary>
    /// <summary>
    /// Updates remote access vpn
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdateRemoteAccessVpn(UpdateRemoteAccessVpnRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdateRemoteAccessVpn(UpdateRemoteAccessVpnRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
