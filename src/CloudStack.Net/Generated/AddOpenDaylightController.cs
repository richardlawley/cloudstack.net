using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddOpenDaylightControllerRequest : APIRequest
    {
        public AddOpenDaylightControllerRequest() : base("addOpenDaylightController") {}

        /// <summary>
        /// Credential to access the OpenDaylight API
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
        /// Api URL of the OpenDaylight Controller.
        /// </summary>
        public string Url {
            get { return GetParameterValue<string>(nameof(Url).ToLower()); }
            set { SetParameterValue(nameof(Url).ToLower(), value); }
        }

        /// <summary>
        /// Username to access the OpenDaylight API
        /// </summary>
        public string Username {
            get { return GetParameterValue<string>(nameof(Username).ToLower()); }
            set { SetParameterValue(nameof(Username).ToLower(), value); }
        }

    }
    /// <summary>
    /// Adds an OpenDyalight controler
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AddOpenDaylightController(AddOpenDaylightControllerRequest request);
        Task<AsyncJobResponse> AddOpenDaylightControllerAsync(AddOpenDaylightControllerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AddOpenDaylightController(AddOpenDaylightControllerRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> AddOpenDaylightControllerAsync(AddOpenDaylightControllerRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
