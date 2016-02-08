using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ClusterResponse
    {
        /// <summary>
        /// the cluster ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the allocation state of the cluster
        /// </summary>
        public string AllocationState { get; set; }

        /// <summary>
        /// the type of the cluster
        /// </summary>
        public string ClusterType { get; set; }

        /// <summary>
        /// The cpu overcommit ratio of the cluster
        /// </summary>
        public string Cpuovercommitratio { get; set; }

        /// <summary>
        /// the hypervisor type of the cluster
        /// </summary>
        public string HypervisorType { get; set; }

        /// <summary>
        /// whether this cluster is managed by cloudstack
        /// </summary>
        public string ManagedState { get; set; }

        /// <summary>
        /// The memory overcommit ratio of the cluster
        /// </summary>
        public string Memoryovercommitratio { get; set; }

        /// <summary>
        /// the cluster name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Ovm3 VIP to use for pooling and/or clustering
        /// </summary>
        public string Ovm3vip { get; set; }

        /// <summary>
        /// the Pod ID of the cluster
        /// </summary>
        public string PodId { get; set; }

        /// <summary>
        /// the Pod name of the cluster
        /// </summary>
        public string PodName { get; set; }

        /// <summary>
        /// the Zone ID of the cluster
        /// </summary>
        public string ZoneId { get; set; }

        /// <summary>
        /// the Zone name of the cluster
        /// </summary>
        public string ZoneName { get; set; }

        /// <summary>
        /// the capacity of the Cluster
        /// </summary>
        public IList<CapacityResponse> Capacity { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
