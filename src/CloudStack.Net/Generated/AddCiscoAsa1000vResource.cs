using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddCiscoAsa1000vResourceRequest : APIRequest
    {
        public AddCiscoAsa1000vResourceRequest() : base("addCiscoAsa1000vResource") {}

        /// <summary>
        /// the Cluster ID
        /// </summary>
        public Guid ClusterId {
            get { return (Guid) Parameters[nameof(ClusterId).ToLower()]; }
            set { Parameters[nameof(ClusterId).ToLower()] = value; }
        }

        /// <summary>
        /// Hostname or ip address of the Cisco ASA 1000v appliance.
        /// </summary>
        public string Hostname {
            get { return (string) Parameters[nameof(Hostname).ToLower()]; }
            set { Parameters[nameof(Hostname).ToLower()] = value; }
        }

        /// <summary>
        /// Nexus port profile associated with inside interface of ASA 1000v
        /// </summary>
        public string Insideportprofile {
            get { return (string) Parameters[nameof(Insideportprofile).ToLower()]; }
            set { Parameters[nameof(Insideportprofile).ToLower()] = value; }
        }

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId {
            get { return (Guid) Parameters[nameof(PhysicalNetworkId).ToLower()]; }
            set { Parameters[nameof(PhysicalNetworkId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Adds a Cisco Asa 1000v appliance
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        CiscoAsa1000vResourceResponse AddCiscoAsa1000vResource(AddCiscoAsa1000vResourceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public CiscoAsa1000vResourceResponse AddCiscoAsa1000vResource(AddCiscoAsa1000vResourceRequest request) => _proxy.Request<CiscoAsa1000vResourceResponse>(request);
    }
}
