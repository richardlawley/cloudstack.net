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
        public string Password { get; set; }

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId { get; set; }

        /// <summary>
        /// Api URL of the OpenDaylight Controller.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Username to access the OpenDaylight API
        /// </summary>
        public string Username { get; set; }

    }
    /// <summary>
    /// Adds an OpenDyalight controler
    /// </summary>
    /// <summary>
    /// Adds an OpenDyalight controler
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        OpenDaylightControllerResponse AddOpenDaylightController(AddOpenDaylightControllerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public OpenDaylightControllerResponse AddOpenDaylightController(AddOpenDaylightControllerRequest request) => _proxy.Request<OpenDaylightControllerResponse>(request);
    }
}
