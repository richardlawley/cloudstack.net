using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class HostResponse
    {
        /// <summary>
        /// the ID of the host
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the cpu average load on the host
        /// </summary>
        public long AverageLoad { get; set; }

        /// <summary>
        /// capabilities of the host
        /// </summary>
        public string Capabilities { get; set; }

        /// <summary>
        /// the cluster ID of the host
        /// </summary>
        public string ClusterId { get; set; }

        /// <summary>
        /// the cluster name of the host
        /// </summary>
        public string ClusterName { get; set; }

        /// <summary>
        /// the cluster type of the cluster that host belongs to
        /// </summary>
        public string ClusterType { get; set; }

        /// <summary>
        /// the amount of the host's CPU currently allocated
        /// </summary>
        public string CpuAllocated { get; set; }

        /// <summary>
        /// the CPU number of the host
        /// </summary>
        public int CpuNumber { get; set; }

        /// <summary>
        /// the number of CPU sockets on the host
        /// </summary>
        public int CpuSockets { get; set; }

        /// <summary>
        /// the CPU speed of the host
        /// </summary>
        public long CpuSpeed { get; set; }

        /// <summary>
        /// the amount of the host's CPU currently used
        /// </summary>
        public string CpuUsed { get; set; }

        /// <summary>
        /// the amount of the host's CPU after applying the cpu.overprovisioning.factor 
        /// </summary>
        public string CpuWithOverprovisioning { get; set; }

        /// <summary>
        /// the date and time the host was created
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Host details in key/value pairs.
        /// </summary>
        public IDictionary<string, string> Details { get; set; }

        /// <summary>
        /// true if the host is disconnected. False otherwise.
        /// </summary>
        public DateTime Disconnected { get; set; }

        /// <summary>
        /// the host's currently allocated disk size
        /// </summary>
        public long DiskSizeAllocated { get; set; }

        /// <summary>
        /// the total disk size of the host
        /// </summary>
        public long DiskSizeTotal { get; set; }

        /// <summary>
        /// events available for the host
        /// </summary>
        public string Events { get; set; }

        /// <summary>
        /// true if the host is Ha host (dedicated to vms started by HA process; false otherwise
        /// </summary>
        public bool HaHost { get; set; }

        /// <summary>
        /// true if this host has enough CPU and RAM capacity to migrate a VM to it, false otherwise
        /// </summary>
        public bool HasEnoughCapacity { get; set; }

        /// <summary>
        /// comma-separated list of tags for the host
        /// </summary>
        public string HostTags { get; set; }

        /// <summary>
        /// the host hypervisor
        /// </summary>
        public HypervisorType Hypervisor { get; set; }

        /// <summary>
        /// the hypervisor version
        /// </summary>
        public string HypervisorVersion { get; set; }

        /// <summary>
        /// the IP address of the host
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// true if local storage is active, false otherwise
        /// </summary>
        public bool Islocalstorageactive { get; set; }

        /// <summary>
        /// the date and time the host was last pinged
        /// </summary>
        public DateTime LastPinged { get; set; }

        /// <summary>
        /// the management server ID of the host
        /// </summary>
        public long ManagementServerId { get; set; }

        /// <summary>
        /// the amount of the host's memory currently allocated
        /// </summary>
        public long MemoryAllocated { get; set; }

        /// <summary>
        /// the memory total of the host
        /// </summary>
        public long MemoryTotal { get; set; }

        /// <summary>
        /// the amount of the host's memory currently used
        /// </summary>
        public long MemoryUsed { get; set; }

        /// <summary>
        /// the name of the host
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the incoming network traffic on the host
        /// </summary>
        public long NetworkKbsRead { get; set; }

        /// <summary>
        /// the outgoing network traffic on the host
        /// </summary>
        public long NetworkKbsWrite { get; set; }

        /// <summary>
        /// the OS category ID of the host
        /// </summary>
        public string OsCategoryId { get; set; }

        /// <summary>
        /// the OS category name of the host
        /// </summary>
        public string OsCategoryName { get; set; }

        /// <summary>
        /// the Pod ID of the host
        /// </summary>
        public string PodId { get; set; }

        /// <summary>
        /// the Pod name of the host
        /// </summary>
        public string PodName { get; set; }

        /// <summary>
        /// the date and time the host was removed
        /// </summary>
        public DateTime Removed { get; set; }

        /// <summary>
        /// the resource state of the host
        /// </summary>
        public string ResourceState { get; set; }

        /// <summary>
        /// the state of the host
        /// </summary>
        public Status State { get; set; }

        /// <summary>
        /// true if this host is suitable(has enough capacity and satisfies all conditions like hosttags, max guests vm limit etc) to migrate a VM to it , false otherwise
        /// </summary>
        public bool SuitableForMigration { get; set; }

        /// <summary>
        /// the host type
        /// </summary>
        public Type Type { get; set; }

        /// <summary>
        /// the host version
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// the Zone ID of the host
        /// </summary>
        public string ZoneId { get; set; }

        /// <summary>
        /// the Zone name of the host
        /// </summary>
        public string ZoneName { get; set; }

        /// <summary>
        /// GPU cards present in the host
        /// </summary>
        public IList<GpuResponse> GpuGroup { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
