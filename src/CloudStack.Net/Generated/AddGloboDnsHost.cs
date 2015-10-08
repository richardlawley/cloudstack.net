using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddGloboDnsHostRequest : APIRequest
    {
        public AddGloboDnsHostRequest() : base("addGloboDnsHost") {}

        /// <summary>
        /// Password for GloboDNS
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId { get; set; }

        /// <summary>
        /// GloboDNS url
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Username for GloboDNS
        /// </summary>
        public string Username { get; set; }

    }
    /// <summary>
    /// Adds the GloboDNS external host
    /// </summary>
    /// <summary>
    /// Adds the GloboDNS external host
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse AddGloboDnsHost(AddGloboDnsHostRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse AddGloboDnsHost(AddGloboDnsHostRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
