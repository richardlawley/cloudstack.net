using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteCiscoAsa1000vResourceRequest : APIRequest
    {
        public DeleteCiscoAsa1000vResourceRequest() : base("deleteCiscoAsa1000vResource") {}

        /// <summary>
        /// Cisco ASA 1000v resource ID
        /// </summary>
        public Guid CiscoAsa1000vResourceId { get; set; }

    }
    /// <summary>
    /// Deletes a Cisco ASA 1000v appliance
    /// </summary>
    /// <summary>
    /// Deletes a Cisco ASA 1000v appliance
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteCiscoAsa1000vResource(DeleteCiscoAsa1000vResourceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteCiscoAsa1000vResource(DeleteCiscoAsa1000vResourceRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
