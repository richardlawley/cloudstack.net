using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteImageStoreRequest : APIRequest
    {
        public DeleteImageStoreRequest() : base("deleteImageStore") {}

        /// <summary>
        /// The image store ID or Secondary Storage ID.
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes an image store or Secondary Storage.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteImageStore(DeleteImageStoreRequest request);
        Task<SuccessResponse> DeleteImageStoreAsync(DeleteImageStoreRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteImageStore(DeleteImageStoreRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteImageStoreAsync(DeleteImageStoreRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
