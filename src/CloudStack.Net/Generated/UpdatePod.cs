using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdatePodRequest : APIRequest
    {
        public UpdatePodRequest() : base("updatePod") {}

        /// <summary>
        /// the ID of the Pod
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Allocation state of this cluster for allocation of new resources
        /// </summary>
        public string AllocationState { get; set; }

        /// <summary>
        /// the ending IP address for the Pod
        /// </summary>
        public string EndIp { get; set; }

        /// <summary>
        /// the gateway for the Pod
        /// </summary>
        public string Gateway { get; set; }

        /// <summary>
        /// the name of the Pod
        /// </summary>
        public string PodName { get; set; }

        /// <summary>
        /// the netmask of the Pod
        /// </summary>
        public string Netmask { get; set; }

        /// <summary>
        /// the starting IP address for the Pod
        /// </summary>
        public string StartIp { get; set; }

    }
    /// <summary>
    /// Updates a Pod.
    /// </summary>
    /// <summary>
    /// Updates a Pod.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        PodResponse UpdatePod(UpdatePodRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public PodResponse UpdatePod(UpdatePodRequest request) => _proxy.Request<PodResponse>(request);
    }
}
