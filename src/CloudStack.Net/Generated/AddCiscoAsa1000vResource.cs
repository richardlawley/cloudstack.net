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
        public Guid ClusterId { get; set; }

        /// <summary>
        /// Hostname or ip address of the Cisco ASA 1000v appliance.
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// Nexus port profile associated with inside interface of ASA 1000v
        /// </summary>
        public string InPortProfile { get; set; }

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId { get; set; }

    }
    /// <summary>
    /// Adds a Cisco Asa 1000v appliance
    /// </summary>
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
