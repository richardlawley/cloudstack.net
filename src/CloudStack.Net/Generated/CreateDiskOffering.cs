using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateDiskOfferingRequest : APIRequest
    {
        public CreateDiskOfferingRequest() : base("createDiskOffering") {}

        /// <summary>
        /// alternate display text of the disk offering
        /// </summary>
        public string DisplayText { get; set; }

        /// <summary>
        /// name of the disk offering
        /// </summary>
        public string OfferingName { get; set; }

        /// <summary>
        /// bytes read rate of the disk offering
        /// </summary>
        public long? BytesReadRate { get; set; }

        /// <summary>
        /// bytes write rate of the disk offering
        /// </summary>
        public long? BytesWriteRate { get; set; }

        /// <summary>
        /// whether disk offering size is custom or not
        /// </summary>
        public bool? Customized { get; set; }

        /// <summary>
        /// whether disk offering iops is custom or not
        /// </summary>
        public bool? CustomizedIops { get; set; }

        /// <summary>
        /// size of the disk offering in GB (1GB = 1,073,741,824 bytes)
        /// </summary>
        public long? DiskSize { get; set; }

        /// <summary>
        /// an optional field, whether to display the offering to the end user or not.
        /// </summary>
        public bool? DisplayOffering { get; set; }

        /// <summary>
        /// the ID of the containing domain, null for public offerings
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// Hypervisor snapshot reserve space as a percent of a volume (for managed storage using Xen or VMware)
        /// </summary>
        public int? HypervisorSnapshotReserve { get; set; }

        /// <summary>
        /// io requests read rate of the disk offering
        /// </summary>
        public long? IopsReadRate { get; set; }

        /// <summary>
        /// io requests write rate of the disk offering
        /// </summary>
        public long? IopsWriteRate { get; set; }

        /// <summary>
        /// max iops of the disk offering
        /// </summary>
        public long? MaxIops { get; set; }

        /// <summary>
        /// min iops of the disk offering
        /// </summary>
        public long? MinIops { get; set; }

        /// <summary>
        /// provisioning type used to create volumes. Valid values are thin, sparse, fat.
        /// </summary>
        public string ProvisioningType { get; set; }

        /// <summary>
        /// the storage type of the disk offering. Values are local and shared.
        /// </summary>
        public string StorageType { get; set; }

        /// <summary>
        /// tags for the disk offering
        /// </summary>
        public string Tags { get; set; }

    }
    /// <summary>
    /// Creates a disk offering.
    /// </summary>
    /// <summary>
    /// Creates a disk offering.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        DiskOfferingResponse CreateDiskOffering(CreateDiskOfferingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public DiskOfferingResponse CreateDiskOffering(CreateDiskOfferingRequest request) => _proxy.Request<DiskOfferingResponse>(request);
    }
}
