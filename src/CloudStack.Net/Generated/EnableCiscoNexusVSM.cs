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
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Enable a Cisco Nexus VSM device
    /// </summary>
    /// <summary>
    /// Enable a Cisco Nexus VSM device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse EnableCiscoNexusVSM(EnableCiscoNexusVSMRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse EnableCiscoNexusVSM(EnableCiscoNexusVSMRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
