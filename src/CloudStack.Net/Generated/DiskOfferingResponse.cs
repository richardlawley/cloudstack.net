using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DiskOfferingResponse
    {
        /// <summary>
        /// unique ID of the disk offering
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the cache mode to use for this disk offering. none, writeback or writethrough
        /// </summary>
        public string CacheMode { get; set; }

        /// <summary>
        /// the date this disk offering was created
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// bytes read rate of the disk offering
        /// </summary>
        public long DiskBytesReadRate { get; set; }

        /// <summary>
        /// bytes write rate of the disk offering
        /// </summary>
        public long DiskBytesWriteRate { get; set; }

        /// <summary>
        /// io requests read rate of the disk offering
        /// </summary>
        public long DiskIopsReadRate { get; set; }

        /// <summary>
        /// io requests write rate of the disk offering
        /// </summary>
        public long DiskIopsWriteRate { get; set; }

        /// <summary>
        /// the size of the disk offering in GB
        /// </summary>
        public long DiskSize { get; set; }

        /// <summary>
        /// whether to display the offering to the end user or not.
        /// </summary>
        public bool DisplayOffering { get; set; }

        /// <summary>
        /// an alternate display text of the disk offering.
        /// </summary>
        public string DisplayText { get; set; }

        /// <summary>
        /// the domain name this disk offering belongs to. Ignore this information as it is not currently applicable.
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the domain ID this disk offering belongs to. Ignore this information as it is not currently applicable.
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// Hypervisor snapshot reserve space as a percent of a volume (for managed storage using Xen or VMware)
        /// </summary>
        public int? HypervisorSnapshotReserve { get; set; }

        /// <summary>
        /// true if disk offering uses custom size, false otherwise
        /// </summary>
        public bool Iscustomized { get; set; }

        /// <summary>
        /// true if disk offering uses custom iops, false otherwise
        /// </summary>
        public bool Iscustomizediops { get; set; }

        /// <summary>
        /// the max iops of the disk offering
        /// </summary>
        public long MaxIops { get; set; }

        /// <summary>
        /// the min iops of the disk offering
        /// </summary>
        public long MinIops { get; set; }

        /// <summary>
        /// the name of the disk offering
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// provisioning type used to create volumes. Valid values are thin, sparse, fat.
        /// </summary>
        public string ProvisioningType { get; set; }

        /// <summary>
        /// the storage type for this disk offering
        /// </summary>
        public string StorageType { get; set; }

        /// <summary>
        /// the tags for the disk offering
        /// </summary>
        public string Tags { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
