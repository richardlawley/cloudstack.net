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
        public string ApiVersion { get; set; }

        /// <summary>
        /// the hostname of the Nuage VSD
        /// </summary>
        public string HostName { get; set; }

        /// <summary>
        /// the password of CMS user in Nuage VSD
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// the ID of the physical network in to which Nuage VSP is added
        /// </summary>
        public Guid PhysicalNetworkId { get; set; }

        /// <summary>
        /// the port to communicate to Nuage VSD
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// the number of retries on failure to communicate to Nuage VSD
        /// </summary>
        public int ApiRetryCount { get; set; }

        /// <summary>
        /// the time to wait after failure before retrying to communicate to Nuage VSD
        /// </summary>
        public long ApiRetryInterval { get; set; }

        /// <summary>
        /// the user name of the CMS user in Nuage VSD
        /// </summary>
        public string UserName { get; set; }

    }
    /// <summary>
    /// Adds a Nuage VSP device
    /// </summary>
    /// <summary>
    /// Adds a Nuage VSP device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        NuageVspDeviceResponse AddNuageVspDevice(AddNuageVspDeviceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public NuageVspDeviceResponse AddNuageVspDevice(AddNuageVspDeviceRequest request) => _proxy.Request<NuageVspDeviceResponse>(request);
    }
}
