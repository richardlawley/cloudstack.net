using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DisableCiscoNexusVSMRequest : APIRequest
    {
        public DisableCiscoNexusVSMRequest() : base("disableCiscoNexusVSM") {}

        /// <summary>
        /// Id of the Cisco Nexus 1000v VSM device to be deleted
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// disable a Cisco Nexus VSM device
    /// </summary>
    /// <summary>
    /// disable a Cisco Nexus VSM device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DisableCiscoNexusVSM(DisableCiscoNexusVSMRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DisableCiscoNexusVSM(DisableCiscoNexusVSMRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
