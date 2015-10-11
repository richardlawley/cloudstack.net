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
        public string Password {
            get { return (string) Parameters[nameof(Password).ToLower()]; }
            set { Parameters[nameof(Password).ToLower()] = value; }
        }

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId {
            get { return (Guid) Parameters[nameof(PhysicalNetworkId).ToLower()]; }
            set { Parameters[nameof(PhysicalNetworkId).ToLower()] = value; }
        }

        /// <summary>
        /// Root directory on PING storage server
        /// </summary>
        public string PingDir {
            get { return (string) Parameters[nameof(PingDir).ToLower()]; }
            set { Parameters[nameof(PingDir).ToLower()] = value; }
        }

        /// <summary>
        /// PING storage server ip
        /// </summary>
        public string PingStorageServerIp {
            get { return (string) Parameters[nameof(PingStorageServerIp).ToLower()]; }
            set { Parameters[nameof(PingStorageServerIp).ToLower()] = value; }
        }

        /// <summary>
        /// type of pxe device
        /// </summary>
        public string Pxeservertype {
            get { return (string) Parameters[nameof(Pxeservertype).ToLower()]; }
            set { Parameters[nameof(Pxeservertype).ToLower()] = value; }
        }

        /// <summary>
        /// Tftp root directory of PXE server
        /// </summary>
        public string TftpDir {
            get { return (string) Parameters[nameof(TftpDir).ToLower()]; }
            set { Parameters[nameof(TftpDir).ToLower()] = value; }
        }

        /// <summary>
        /// URL of the external pxe device
        /// </summary>
        public string Url {
            get { return (string) Parameters[nameof(Url).ToLower()]; }
            set { Parameters[nameof(Url).ToLower()] = value; }
        }

        /// <summary>
        /// Credentials to reach external pxe device
        /// </summary>
        public string Username {
            get { return (string) Parameters[nameof(Username).ToLower()]; }
            set { Parameters[nameof(Username).ToLower()] = value; }
        }

        /// <summary>
        /// Password of PING storage server
        /// </summary>
        public string Pingcifspassword {
            get { return (string) Parameters[nameof(Pingcifspassword).ToLower()]; }
            set { Parameters[nameof(Pingcifspassword).ToLower()] = value; }
        }

        /// <summary>
        /// Username of PING storage server
        /// </summary>
        public string Pingcifsusername {
            get { return (string) Parameters[nameof(Pingcifsusername).ToLower()]; }
            set { Parameters[nameof(Pingcifsusername).ToLower()] = value; }
        }

        /// <summary>
        /// Pod Id
        /// </summary>
        public Guid PodId {
            get { return (Guid) Parameters[nameof(PodId).ToLower()]; }
            set { Parameters[nameof(PodId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// add a baremetal ping pxe server
    /// </summary>
    /// <summary>
    /// add a baremetal ping pxe server
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AddBaremetalPxePingServer(AddBaremetalPxePingServerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AddBaremetalPxePingServer(AddBaremetalPxePingServerRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
