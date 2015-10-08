using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteNetworkRequest : APIRequest
    {
        public DeleteNetworkRequest() : base("deleteNetwork") {}

        /// <summary>
        /// the ID of the network
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Force delete a network. Network will be marked as 'Destroy' even when commands to shutdown and cleanup to the backend fails.
        /// </summary>
        public bool? Forced { get; set; }

    }
    /// <summary>
    /// Deletes a network
    /// </summary>
    /// <summary>
    /// Deletes a network
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteNetwork(DeleteNetworkRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteNetwork(DeleteNetworkRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
