using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (string) Parameters[nameof(Password).ToLower()]; }
            set { Parameters[nameof(Password).ToLower()] = value; }
        }

        /// <summary>
        /// the username for the host/cluster
        /// </summary>
        public string Username {
            get { return (string) Parameters[nameof(Username).ToLower()]; }
            set { Parameters[nameof(Username).ToLower()] = value; }
        }

        /// <summary>
        /// the cluster ID
        /// </summary>
        public Guid ClusterId {
            get { return (Guid) Parameters[nameof(ClusterId).ToLower()]; }
            set { Parameters[nameof(ClusterId).ToLower()] = value; }
        }

        /// <summary>
        /// the host ID
        /// </summary>
        public Guid HostId {
            get { return (Guid) Parameters[nameof(HostId).ToLower()]; }
            set { Parameters[nameof(HostId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Update password of a host/pool on management server.
    /// </summary>
    /// <summary>
    /// Update password of a host/pool on management server.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse UpdateHostPassword(UpdateHostPasswordRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse UpdateHostPassword(UpdateHostPasswordRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
