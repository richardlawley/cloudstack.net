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
        public string Hostname {
            get { return (string) Parameters[nameof(Hostname).ToLower()]; }
            set { Parameters[nameof(Hostname).ToLower()] = value; }
        }

        /// <summary>
        /// Credentials to access the Cisco VNMC Controller API
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
        /// Credentials to access the Cisco VNMC Controller API
        /// </summary>
        public string Username {
            get { return (string) Parameters[nameof(Username).ToLower()]; }
            set { Parameters[nameof(Username).ToLower()] = value; }
        }

    }
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
