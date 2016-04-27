using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<string>(nameof(Password).ToLower()); }
            set { SetParameterValue(nameof(Password).ToLower(), value); }
        }

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId {
            get { return GetParameterValue<Guid>(nameof(PhysicalNetworkId).ToLower()); }
            set { SetParameterValue(nameof(PhysicalNetworkId).ToLower(), value); }
        }

        /// <summary>
        /// Root directory on PING storage server
        /// </summary>
        public string PingDir {
            get { return GetParameterValue<string>(nameof(PingDir).ToLower()); }
            set { SetParameterValue(nameof(PingDir).ToLower(), value); }
        }

        /// <summary>
        /// PING storage server ip
        /// </summary>
        public string PingStorageServerIp {
            get { return GetParameterValue<string>(nameof(PingStorageServerIp).ToLower()); }
            set { SetParameterValue(nameof(PingStorageServerIp).ToLower(), value); }
        }

        /// <summary>
        /// type of pxe device
        /// </summary>
        public string Pxeservertype {
            get { return GetParameterValue<string>(nameof(Pxeservertype).ToLower()); }
            set { SetParameterValue(nameof(Pxeservertype).ToLower(), value); }
        }

        /// <summary>
        /// Tftp root directory of PXE server
        /// </summary>
        public string TftpDir {
            get { return GetParameterValue<string>(nameof(TftpDir).ToLower()); }
            set { SetParameterValue(nameof(TftpDir).ToLower(), value); }
        }

        /// <summary>
        /// URL of the external pxe device
        /// </summary>
        public string Url {
            get { return GetParameterValue<string>(nameof(Url).ToLower()); }
            set { SetParameterValue(nameof(Url).ToLower(), value); }
        }

        /// <summary>
        /// Credentials to reach external pxe device
        /// </summary>
        public string Username {
            get { return GetParameterValue<string>(nameof(Username).ToLower()); }
            set { SetParameterValue(nameof(Username).ToLower(), value); }
        }

        /// <summary>
        /// Password of PING storage server
        /// </summary>
        public string Pingcifspassword {
            get { return GetParameterValue<string>(nameof(Pingcifspassword).ToLower()); }
            set { SetParameterValue(nameof(Pingcifspassword).ToLower(), value); }
        }

        /// <summary>
        /// Username of PING storage server
        /// </summary>
        public string Pingcifsusername {
            get { return GetParameterValue<string>(nameof(Pingcifsusername).ToLower()); }
            set { SetParameterValue(nameof(Pingcifsusername).ToLower(), value); }
        }

        /// <summary>
        /// Pod Id
        /// </summary>
        public Guid? PodId {
            get { return GetParameterValue<Guid?>(nameof(PodId).ToLower()); }
            set { SetParameterValue(nameof(PodId).ToLower(), value); }
        }

    }
    /// <summary>
    /// add a baremetal ping pxe server
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AddBaremetalPxePingServer(AddBaremetalPxePingServerRequest request);
        Task<AsyncJobResponse> AddBaremetalPxePingServerAsync(AddBaremetalPxePingServerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AddBaremetalPxePingServer(AddBaremetalPxePingServerRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> AddBaremetalPxePingServerAsync(AddBaremetalPxePingServerRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
