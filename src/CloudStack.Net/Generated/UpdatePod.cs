using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdatePodRequest : APIRequest
    {
        public UpdatePodRequest() : base("updatePod") {}

        /// <summary>
        /// the ID of the Pod
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// Allocation state of this cluster for allocation of new resources
        /// </summary>
        public string AllocationState {
            get { return (string) Parameters[nameof(AllocationState).ToLower()]; }
            set { Parameters[nameof(AllocationState).ToLower()] = value; }
        }

        /// <summary>
        /// the ending IP address for the Pod
        /// </summary>
        public string EndIp {
            get { return (string) Parameters[nameof(EndIp).ToLower()]; }
            set { Parameters[nameof(EndIp).ToLower()] = value; }
        }

        /// <summary>
        /// the gateway for the Pod
        /// </summary>
        public string Gateway {
            get { return (string) Parameters[nameof(Gateway).ToLower()]; }
            set { Parameters[nameof(Gateway).ToLower()] = value; }
        }

        /// <summary>
        /// the name of the Pod
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// the netmask of the Pod
        /// </summary>
        public string Netmask {
            get { return (string) Parameters[nameof(Netmask).ToLower()]; }
            set { Parameters[nameof(Netmask).ToLower()] = value; }
        }

        /// <summary>
        /// the starting IP address for the Pod
        /// </summary>
        public string StartIp {
            get { return (string) Parameters[nameof(StartIp).ToLower()]; }
            set { Parameters[nameof(StartIp).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Updates a Pod.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        PodResponse UpdatePod(UpdatePodRequest request);
        Task<PodResponse> UpdatePodAsync(UpdatePodRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public PodResponse UpdatePod(UpdatePodRequest request) => _proxy.Request<PodResponse>(request);
        public Task<PodResponse> UpdatePodAsync(UpdatePodRequest request) => _proxy.RequestAsync<PodResponse>(request);
    }
}
