using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddBaremetalPxePingServerRequest : APIRequest
    {
        public AddBaremetalPxePingServerRequest() : base("addBaremetalPxePingServer") {}

        /// <summary>
        /// Credentials to reach external pxe device
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId { get; set; }

        /// <summary>
        /// Root directory on PING storage server
        /// </summary>
        public string PingDir { get; set; }

        /// <summary>
        /// PING storage server ip
        /// </summary>
        public string PingStorageServerIp { get; set; }

        /// <summary>
        /// type of pxe device
        /// </summary>
        public string DeviceType { get; set; }

        /// <summary>
        /// Tftp root directory of PXE server
        /// </summary>
        public string TftpDir { get; set; }

        /// <summary>
        /// URL of the external pxe device
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Credentials to reach external pxe device
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Password of PING storage server
        /// </summary>
        public string PingStorageServerPassword { get; set; }

        /// <summary>
        /// Username of PING storage server
        /// </summary>
        public string PingStorageServerUserName { get; set; }

        /// <summary>
        /// Pod Id
        /// </summary>
        public Guid PodId { get; set; }

    }
    /// <summary>
    /// add a baremetal ping pxe server
    /// </summary>
    /// <summary>
    /// add a baremetal ping pxe server
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        BaremetalPxePingResponse AddBaremetalPxePingServer(AddBaremetalPxePingServerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public BaremetalPxePingResponse AddBaremetalPxePingServer(AddBaremetalPxePingServerRequest request) => _proxy.Request<BaremetalPxePingResponse>(request);
    }
}
