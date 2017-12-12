using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteSecondaryStagingStoreRequest : APIRequest
    {
        public DeleteSecondaryStagingStoreRequest() : base("deleteSecondaryStagingStore") {}

        /// <summary>
        /// the staging store ID
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a secondary staging store .
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteSecondaryStagingStore(DeleteSecondaryStagingStoreRequest request);
        Task<SuccessResponse> DeleteSecondaryStagingStoreAsync(DeleteSecondaryStagingStoreRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteSecondaryStagingStore(DeleteSecondaryStagingStoreRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteSecondaryStagingStoreAsync(DeleteSecondaryStagingStoreRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
