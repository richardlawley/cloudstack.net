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
        public string Password { get; set; }

        /// <summary>
        /// the username for the host/cluster
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// the cluster ID
        /// </summary>
        public Guid ClusterId { get; set; }

        /// <summary>
        /// the host ID
        /// </summary>
        public Guid HostId { get; set; }

        /// <summary>
        /// if the password should also be updated on the hosts
        /// </summary>
        public bool? UpdatePasswdOnHost { get; set; }

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
