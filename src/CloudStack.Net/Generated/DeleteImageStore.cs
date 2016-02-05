using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Deletes an image store or Secondary Storage.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteImageStore(DeleteImageStoreRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteImageStore(DeleteImageStoreRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
