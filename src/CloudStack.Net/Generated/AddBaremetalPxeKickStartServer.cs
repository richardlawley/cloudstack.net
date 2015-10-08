using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddBaremetalPxeKickStartServerRequest : APIRequest
    {
        public AddBaremetalPxeKickStartServerRequest() : base("addBaremetalPxeKickStartServer") {}

        /// <summary>
        /// Credentials to reach external pxe device
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId { get; set; }

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
        /// Pod Id
        /// </summary>
        public Guid PodId { get; set; }

    }
    /// <summary>
    /// add a baremetal pxe server
    /// </summary>
    /// <summary>
    /// add a baremetal pxe server
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        BaremetalPxeKickStartResponse AddBaremetalPxeKickStartServer(AddBaremetalPxeKickStartServerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public BaremetalPxeKickStartResponse AddBaremetalPxeKickStartServer(AddBaremetalPxeKickStartServerRequest request) => _proxy.Request<BaremetalPxeKickStartResponse>(request);
    }
}
