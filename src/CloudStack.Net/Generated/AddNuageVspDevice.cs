using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<string>(nameof(ApiVersion).ToLower()); }
            set { SetParameterValue(nameof(ApiVersion).ToLower(), value); }
        }

        /// <summary>
        /// the hostname of the Nuage VSD
        /// </summary>
        public string HostName {
            get { return GetParameterValue<string>(nameof(HostName).ToLower()); }
            set { SetParameterValue(nameof(HostName).ToLower(), value); }
        }

        /// <summary>
        /// the password of CMS user in Nuage VSD
        /// </summary>
        public string Password {
            get { return GetParameterValue<string>(nameof(Password).ToLower()); }
            set { SetParameterValue(nameof(Password).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the physical network in to which Nuage VSP is added
        /// </summary>
        public Guid PhysicalNetworkId {
            get { return GetParameterValue<Guid>(nameof(PhysicalNetworkId).ToLower()); }
            set { SetParameterValue(nameof(PhysicalNetworkId).ToLower(), value); }
        }

        /// <summary>
        /// the port to communicate to Nuage VSD
        /// </summary>
        public int? Port {
            get { return GetParameterValue<int?>(nameof(Port).ToLower()); }
            set { SetParameterValue(nameof(Port).ToLower(), value); }
        }

        /// <summary>
        /// the number of retries on failure to communicate to Nuage VSD
        /// </summary>
        public int? Retrycount {
            get { return GetParameterValue<int?>(nameof(Retrycount).ToLower()); }
            set { SetParameterValue(nameof(Retrycount).ToLower(), value); }
        }

        /// <summary>
        /// the time to wait after failure before retrying to communicate to Nuage VSD
        /// </summary>
        public long Retryinterval {
            get { return GetParameterValue<long>(nameof(Retryinterval).ToLower()); }
            set { SetParameterValue(nameof(Retryinterval).ToLower(), value); }
        }

        /// <summary>
        /// the user name of the CMS user in Nuage VSD
        /// </summary>
        public string UserName {
            get { return GetParameterValue<string>(nameof(UserName).ToLower()); }
            set { SetParameterValue(nameof(UserName).ToLower(), value); }
        }

    }
    /// <summary>
    /// Adds a Nuage VSP device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AddNuageVspDevice(AddNuageVspDeviceRequest request);
        Task<AsyncJobResponse> AddNuageVspDeviceAsync(AddNuageVspDeviceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AddNuageVspDevice(AddNuageVspDeviceRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> AddNuageVspDeviceAsync(AddNuageVspDeviceRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
