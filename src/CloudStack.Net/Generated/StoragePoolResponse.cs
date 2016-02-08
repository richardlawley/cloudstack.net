using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class StoragePoolResponse
    {
        /// <summary>
        /// the ID of the storage pool
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// IOPS CloudStack can provision from this storage pool
        /// </summary>
        public long CapacityIops { get; set; }

        /// <summary>
        /// the ID of the cluster for the storage pool
        /// </summary>
        public string ClusterId { get; set; }

        /// <summary>
        /// the name of the cluster for the storage pool
        /// </summary>
        public string ClusterName { get; set; }

        /// <summary>
        /// the date and time the storage pool was created
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// the host's currently allocated disk size
        /// </summary>
        public long DiskSizeAllocated { get; set; }

        /// <summary>
        /// the total disk size of the storage pool
        /// </summary>
        public long DiskSizeTotal { get; set; }

        /// <summary>
        /// the host's currently used disk size
        /// </summary>
        public long DiskSizeUsed { get; set; }

        /// <summary>
        /// the hypervisor type of the storage pool
        /// </summary>
        public string Hypervisor { get; set; }

        /// <summary>
        /// the IP address of the storage pool
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// the name of the storage pool
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the overprovisionfactor for the storage pool
        /// </summary>
        public string OverProvisionFactor { get; set; }

        /// <summary>
        /// the storage pool path
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// the Pod ID of the storage pool
        /// </summary>
        public string PodId { get; set; }

        /// <summary>
        /// the Pod name of the storage pool
        /// </summary>
        public string PodName { get; set; }

        /// <summary>
        /// the scope of the storage pool
        /// </summary>
        public string Scope { get; set; }

        /// <summary>
        /// the state of the storage pool
        /// </summary>
        public StoragePoolStatus State { get; set; }

        /// <summary>
        /// the storage pool capabilities
        /// </summary>
        public IDictionary<string, string> Storagecapabilities { get; set; }

        /// <summary>
        /// true if this pool is suitable to migrate a volume, false otherwise
        /// </summary>
        public bool SuitableForMigration { get; set; }

        /// <summary>
        /// the tags for the storage pool
        /// </summary>
        public string Tags { get; set; }

        /// <summary>
        /// the storage pool type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// the Zone ID of the storage pool
        /// </summary>
        public string ZoneId { get; set; }

        /// <summary>
        /// the Zone name of the storage pool
        /// </summary>
        public string ZoneName { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
