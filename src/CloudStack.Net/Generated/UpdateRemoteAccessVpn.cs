using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId {
            get { return GetParameterValue<string>(nameof(CustomId).ToLower()); }
            set { SetParameterValue(nameof(CustomId).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, whether to the display the vpn to the end user or not
        /// </summary>
        public bool? Fordisplay {
            get { return GetParameterValue<bool?>(nameof(Fordisplay).ToLower()); }
            set { SetParameterValue(nameof(Fordisplay).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates remote access vpn
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdateRemoteAccessVpn(UpdateRemoteAccessVpnRequest request);
        Task<AsyncJobResponse> UpdateRemoteAccessVpnAsync(UpdateRemoteAccessVpnRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdateRemoteAccessVpn(UpdateRemoteAccessVpnRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> UpdateRemoteAccessVpnAsync(UpdateRemoteAccessVpnRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
