using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
        /// Api URL of the OpenDaylight Controller.
        /// </summary>
        public string Url {
            get { return (string) Parameters[nameof(Url).ToLower()]; }
            set { Parameters[nameof(Url).ToLower()] = value; }
        }

        /// <summary>
        /// Username to access the OpenDaylight API
        /// </summary>
        public string Username {
            get { return (string) Parameters[nameof(Username).ToLower()]; }
            set { Parameters[nameof(Username).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Adds an OpenDyalight controler
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AddOpenDaylightController(AddOpenDaylightControllerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AddOpenDaylightController(AddOpenDaylightControllerRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
