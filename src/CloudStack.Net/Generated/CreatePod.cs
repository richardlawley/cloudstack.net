using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreatePodRequest : APIRequest
    {
        public CreatePodRequest() : base("createPod") {}

        /// <summary>
        /// the gateway for the Pod
        /// </summary>
        public string Gateway { get; set; }

        /// <summary>
        /// the name of the Pod
        /// </summary>
        public string PodName { get; set; }

        /// <summary>
        /// the netmask for the Pod
        /// </summary>
        public string Netmask { get; set; }

        /// <summary>
        /// the starting IP address for the Pod
        /// </summary>
        public string StartIp { get; set; }

        /// <summary>
        /// the Zone ID in which the Pod will be created
        /// </summary>
        public Guid ZoneId { get; set; }

        /// <summary>
        /// Allocation state of this Pod for allocation of new resources
        /// </summary>
        public string AllocationState { get; set; }

        /// <summary>
        /// the ending IP address for the Pod
        /// </summary>
        public string EndIp { get; set; }

    }
    /// <summary>
    /// Creates a new Pod.
    /// </summary>
    /// <summary>
    /// Creates a new Pod.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        PodResponse CreatePod(CreatePodRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public PodResponse CreatePod(CreatePodRequest request) => _proxy.Request<PodResponse>(request);
    }
}
