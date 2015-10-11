using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    /// <summary>
    /// Release the dedication for the pod
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse ReleaseDedicatedPod(ReleaseDedicatedPodRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse ReleaseDedicatedPod(ReleaseDedicatedPodRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
