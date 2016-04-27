using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateHostPasswordRequest : APIRequest
    {
        public UpdateHostPasswordRequest() : base("updateHostPassword") {}

        /// <summary>
        /// the new password for the host/cluster
        /// </summary>
        public string Password {
            get { return GetParameterValue<string>(nameof(Password).ToLower()); }
            set { SetParameterValue(nameof(Password).ToLower(), value); }
        }

        /// <summary>
        /// the username for the host/cluster
        /// </summary>
        public string Username {
            get { return GetParameterValue<string>(nameof(Username).ToLower()); }
            set { SetParameterValue(nameof(Username).ToLower(), value); }
        }

        /// <summary>
        /// the cluster ID
        /// </summary>
        public Guid? ClusterId {
            get { return GetParameterValue<Guid?>(nameof(ClusterId).ToLower()); }
            set { SetParameterValue(nameof(ClusterId).ToLower(), value); }
        }

        /// <summary>
        /// the host ID
        /// </summary>
        public Guid? HostId {
            get { return GetParameterValue<Guid?>(nameof(HostId).ToLower()); }
            set { SetParameterValue(nameof(HostId).ToLower(), value); }
        }

        /// <summary>
        /// if the password should also be updated on the hosts
        /// </summary>
        public bool? Update_passwd_on_host {
            get { return GetParameterValue<bool?>(nameof(Update_passwd_on_host).ToLower()); }
            set { SetParameterValue(nameof(Update_passwd_on_host).ToLower(), value); }
        }

    }
    /// <summary>
    /// Update password of a host/pool on management server.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse UpdateHostPassword(UpdateHostPasswordRequest request);
        Task<SuccessResponse> UpdateHostPasswordAsync(UpdateHostPasswordRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse UpdateHostPassword(UpdateHostPasswordRequest request) => _proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> UpdateHostPasswordAsync(UpdateHostPasswordRequest request) => _proxy.RequestAsync<SuccessResponse>(request);
    }
}
