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
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Deletes a Physical Network.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeletePhysicalNetwork(DeletePhysicalNetworkRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeletePhysicalNetwork(DeletePhysicalNetworkRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
