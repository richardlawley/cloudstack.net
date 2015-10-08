using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ServiceOfferingResponse
    {
        /// <summary>
        /// the id of the service offering
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the number of CPU
        /// </summary>
        public int CpuNumber { get; set; }

        /// <summary>
        /// the clock rate CPU speed in Mhz
        /// </summary>
        public int CpuSpeed { get; set; }

        /// <summary>
        /// the date this service offering was created
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// is this a  default system vm offering
        /// </summary>
        public bool DefaultUse { get; set; }

        /// <summary>
        /// deployment strategy used to deploy VM.
        /// </summary>
        public string DeploymentPlanner { get; set; }

        /// <summary>
        /// bytes read rate of the service offering
        /// </summary>
        public long DiskBytesReadRate { get; set; }

        /// <summary>
        /// bytes write rate of the service offering
        /// </summary>
        public long DiskBytesWriteRate { get; set; }

        /// <summary>
        /// io requests read rate of the service offering
        /// </summary>
        public long DiskIopsReadRate { get; set; }

        /// <summary>
        /// io requests write rate of the service offering
        /// </summary>
        public long DiskIopsWriteRate { get; set; }

        /// <summary>
        /// an alternate display text of the service offering.
        /// </summary>
        public string DisplayText { get; set; }

        /// <summary>
        /// Domain name for the offering
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the domain id of the service offering
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// the host tag for the service offering
        /// </summary>
        public string Hosttags { get; set; }

        /// <summary>
        /// Hypervisor snapshot reserve space as a percent of a volume (for managed storage using Xen or VMware)
        /// </summary>
        public int HypervisorSnapshotReserve { get; set; }

        /// <summary>
        /// is true if the offering is customized
        /// </summary>
        public bool IsCustomized { get; set; }

        /// <summary>
        /// true if disk offering uses custom iops, false otherwise
        /// </summary>
        public bool Iscustomizediops { get; set; }

        /// <summary>
        /// is this a system vm offering
        /// </summary>
        public bool IsSystem { get; set; }

        /// <summary>
        /// true if the vm needs to be volatile, i.e., on every reboot of vm from API root disk is discarded and creates a new root disk
        /// </summary>
        public bool IsVolatile { get; set; }

        /// <summary>
        /// restrict the CPU usage to committed service offering
        /// </summary>
        public bool LimitCpuUse { get; set; }

        /// <summary>
        /// the max iops of the disk offering
        /// </summary>
        public long MaxIops { get; set; }

        /// <summary>
        /// the memory in MB
        /// </summary>
        public int Memory { get; set; }

        /// <summary>
        /// the min iops of the disk offering
        /// </summary>
        public long MinIops { get; set; }

        /// <summary>
        /// the name of the service offering
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// data transfer rate in megabits per second allowed.
        /// </summary>
        public int NetworkRate { get; set; }

        /// <summary>
        /// the ha support in the service offering
        /// </summary>
        public bool OfferHa { get; set; }

        /// <summary>
        /// provisioning type used to create volumes. Valid values are thin, sparse, fat.
        /// </summary>
        public string ProvisioningType { get; set; }

        /// <summary>
        /// additional key/value details tied with this service offering
        /// </summary>
        public IDictionary<string, string> Serviceofferingdetails { get; set; }

        /// <summary>
        /// the storage type for this service offering
        /// </summary>
        public string StorageType { get; set; }

        /// <summary>
        /// is this a the systemvm type for system vm offering
        /// </summary>
        public string Systemvmtype { get; set; }

        /// <summary>
        /// the tags for the service offering
        /// </summary>
        public string Tags { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
