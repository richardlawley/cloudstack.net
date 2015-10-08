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
        public Guid Id { get; set; }

    }
    /// <summary>
    ///  delete a Cisco Nexus VSM device
    /// </summary>
    /// <summary>
    ///  delete a Cisco Nexus VSM device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteCiscoNexusVSM(DeleteCiscoNexusVSMRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteCiscoNexusVSM(DeleteCiscoNexusVSMRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
