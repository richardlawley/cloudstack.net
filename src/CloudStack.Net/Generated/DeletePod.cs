using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeletePodRequest : APIRequest
    {
        public DeletePodRequest() : base("deletePod") {}

        /// <summary>
        /// the ID of the Pod
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Deletes a Pod.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeletePod(DeletePodRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeletePod(DeletePodRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
