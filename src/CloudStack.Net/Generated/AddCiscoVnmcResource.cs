using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddCiscoVnmcResourceRequest : APIRequest
    {
        public AddCiscoVnmcResourceRequest() : base("addCiscoVnmcResource") {}

        /// <summary>
        /// Hostname or ip address of the Cisco VNMC Controller.
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// Credentials to access the Cisco VNMC Controller API
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId { get; set; }

        /// <summary>
        /// Credentials to access the Cisco VNMC Controller API
        /// </summary>
        public string Username { get; set; }

    }
    /// <summary>
    /// Adds a Cisco Vnmc Controller
    /// </summary>
    /// <summary>
    /// Adds a Cisco Vnmc Controller
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        CiscoVnmcResourceResponse AddCiscoVnmcResource(AddCiscoVnmcResourceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public CiscoVnmcResourceResponse AddCiscoVnmcResource(AddCiscoVnmcResourceRequest request) => _proxy.Request<CiscoVnmcResourceResponse>(request);
    }
}
