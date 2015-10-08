using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeletePhysicalNetworkRequest : APIRequest
    {
        public DeletePhysicalNetworkRequest() : base("deletePhysicalNetwork") {}

        /// <summary>
        /// the ID of the Physical network
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Deletes a Physical Network.
    /// </summary>
    /// <summary>
    /// Deletes a Physical Network.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeletePhysicalNetwork(DeletePhysicalNetworkRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeletePhysicalNetwork(DeletePhysicalNetworkRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
