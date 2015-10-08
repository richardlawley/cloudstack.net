using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteSecondaryStagingStoreRequest : APIRequest
    {
        public DeleteSecondaryStagingStoreRequest() : base("deleteSecondaryStagingStore") {}

        /// <summary>
        /// the staging store ID
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Deletes a secondary staging store .
    /// </summary>
    /// <summary>
    /// Deletes a secondary staging store .
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteSecondaryStagingStore(DeleteSecondaryStagingStoreRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteSecondaryStagingStore(DeleteSecondaryStagingStoreRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
