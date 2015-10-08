using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class EnableCiscoNexusVSMRequest : APIRequest
    {
        public EnableCiscoNexusVSMRequest() : base("enableCiscoNexusVSM") {}

        /// <summary>
        /// Id of the Cisco Nexus 1000v VSM device to be enabled
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Enable a Cisco Nexus VSM device
    /// </summary>
    /// <summary>
    /// Enable a Cisco Nexus VSM device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        CiscoNexusVSMResponse EnableCiscoNexusVSM(EnableCiscoNexusVSMRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public CiscoNexusVSMResponse EnableCiscoNexusVSM(EnableCiscoNexusVSMRequest request) => _proxy.Request<CiscoNexusVSMResponse>(request);
    }
}
