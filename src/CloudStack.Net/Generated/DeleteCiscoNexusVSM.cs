using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteCiscoNexusVSMRequest : APIRequest
    {
        public DeleteCiscoNexusVSMRequest() : base("deleteCiscoNexusVSM") {}

        /// <summary>
        /// Id of the Cisco Nexus 1000v VSM device to be deleted
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    ///  delete a Cisco Nexus VSM device
    /// </summary>
    /// <summary>
    ///  delete a Cisco Nexus VSM device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteCiscoNexusVSM(DeleteCiscoNexusVSMRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteCiscoNexusVSM(DeleteCiscoNexusVSMRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
