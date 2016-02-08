using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ReleaseDedicatedPodRequest : APIRequest
    {
        public ReleaseDedicatedPodRequest() : base("releaseDedicatedPod") {}

        /// <summary>
        /// the ID of the Pod
        /// </summary>
        public Guid PodId {
            get { return (Guid) Parameters[nameof(PodId).ToLower()]; }
            set { Parameters[nameof(PodId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Release the dedication for the pod
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ReleaseDedicatedPod(ReleaseDedicatedPodRequest request);
        Task<AsyncJobResponse> ReleaseDedicatedPodAsync(ReleaseDedicatedPodRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ReleaseDedicatedPod(ReleaseDedicatedPodRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> ReleaseDedicatedPodAsync(ReleaseDedicatedPodRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
