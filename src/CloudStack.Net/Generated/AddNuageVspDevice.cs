using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddNuageVspDeviceRequest : APIRequest
    {
        public AddNuageVspDeviceRequest() : base("addNuageVspDevice") {}

        /// <summary>
        /// the version of the API to use to communicate to Nuage VSD
        /// </summary>
        public string ApiVersion {
            get { return (string) Parameters[nameof(ApiVersion).ToLower()]; }
            set { Parameters[nameof(ApiVersion).ToLower()] = value; }
        }

        /// <summary>
        /// the hostname of the Nuage VSD
        /// </summary>
        public string HostName {
            get { return (string) Parameters[nameof(HostName).ToLower()]; }
            set { Parameters[nameof(HostName).ToLower()] = value; }
        }

        /// <summary>
        /// the password of CMS user in Nuage VSD
        /// </summary>
        public string Password {
            get { return (string) Parameters[nameof(Password).ToLower()]; }
            set { Parameters[nameof(Password).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the physical network in to which Nuage VSP is added
        /// </summary>
        public Guid PhysicalNetworkId {
            get { return (Guid) Parameters[nameof(PhysicalNetworkId).ToLower()]; }
            set { Parameters[nameof(PhysicalNetworkId).ToLower()] = value; }
        }

        /// <summary>
        /// the port to communicate to Nuage VSD
        /// </summary>
        public int Port {
            get { return (int) Parameters[nameof(Port).ToLower()]; }
            set { Parameters[nameof(Port).ToLower()] = value; }
        }

        /// <summary>
        /// the number of retries on failure to communicate to Nuage VSD
        /// </summary>
        public int Retrycount {
            get { return (int) Parameters[nameof(Retrycount).ToLower()]; }
            set { Parameters[nameof(Retrycount).ToLower()] = value; }
        }

        /// <summary>
        /// the time to wait after failure before retrying to communicate to Nuage VSD
        /// </summary>
        public long Retryinterval {
            get { return (long) Parameters[nameof(Retryinterval).ToLower()]; }
            set { Parameters[nameof(Retryinterval).ToLower()] = value; }
        }

        /// <summary>
        /// the user name of the CMS user in Nuage VSD
        /// </summary>
        public string UserName {
            get { return (string) Parameters[nameof(UserName).ToLower()]; }
            set { Parameters[nameof(UserName).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Adds a Nuage VSP device
    /// </summary>
    /// <summary>
    /// Adds a Nuage VSP device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AddNuageVspDevice(AddNuageVspDeviceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AddNuageVspDevice(AddNuageVspDeviceRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
