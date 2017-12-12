using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddBaremetalPxeKickStartServerRequest : APIRequest
    {
        public AddBaremetalPxeKickStartServerRequest() : base("addBaremetalPxeKickStartServer") {}

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
        /// Pod Id
        /// </summary>
        public Guid? PodId {
            get { return GetParameterValue<Guid?>(nameof(PodId).ToLower()); }
            set { SetParameterValue(nameof(PodId).ToLower(), value); }
        }

    }
    /// <summary>
    /// add a baremetal pxe server
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AddBaremetalPxeKickStartServer(AddBaremetalPxeKickStartServerRequest request);
        Task<AsyncJobResponse> AddBaremetalPxeKickStartServerAsync(AddBaremetalPxeKickStartServerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AddBaremetalPxeKickStartServer(AddBaremetalPxeKickStartServerRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> AddBaremetalPxeKickStartServerAsync(AddBaremetalPxeKickStartServerRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
