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
        public string DisplayText {
            get { return (string) Parameters[nameof(DisplayText).ToLower()]; }
            set { Parameters[nameof(DisplayText).ToLower()] = value; }
        }

        /// <summary>
        /// name of the disk offering
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// bytes read rate of the disk offering
        /// </summary>
        public long? BytesReadRate {
            get { return (long?) Parameters[nameof(BytesReadRate).ToLower()]; }
            set { Parameters[nameof(BytesReadRate).ToLower()] = value; }
        }

        /// <summary>
        /// bytes write rate of the disk offering
        /// </summary>
        public long? BytesWriteRate {
            get { return (long?) Parameters[nameof(BytesWriteRate).ToLower()]; }
            set { Parameters[nameof(BytesWriteRate).ToLower()] = value; }
        }

        /// <summary>
        /// whether disk offering size is custom or not
        /// </summary>
        public bool? Customized {
            get { return (bool?) Parameters[nameof(Customized).ToLower()]; }
            set { Parameters[nameof(Customized).ToLower()] = value; }
        }

        /// <summary>
        /// whether disk offering iops is custom or not
        /// </summary>
        public bool? CustomizedIops {
            get { return (bool?) Parameters[nameof(CustomizedIops).ToLower()]; }
            set { Parameters[nameof(CustomizedIops).ToLower()] = value; }
        }

        /// <summary>
        /// size of the disk offering in GB
        /// </summary>
        public long? DiskSize {
            get { return (long?) Parameters[nameof(DiskSize).ToLower()]; }
            set { Parameters[nameof(DiskSize).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, whether to display the offering to the end user or not.
        /// </summary>
        public bool? DisplayOffering {
            get { return (bool?) Parameters[nameof(DisplayOffering).ToLower()]; }
            set { Parameters[nameof(DisplayOffering).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the containing domain, null for public offerings
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// Hypervisor snapshot reserve space as a percent of a volume (for managed storage using Xen or VMware)
        /// </summary>
        public int? HypervisorSnapshotReserve {
            get { return (int?) Parameters[nameof(HypervisorSnapshotReserve).ToLower()]; }
            set { Parameters[nameof(HypervisorSnapshotReserve).ToLower()] = value; }
        }

        /// <summary>
        /// io requests read rate of the disk offering
        /// </summary>
        public long? IopsReadRate {
            get { return (long?) Parameters[nameof(IopsReadRate).ToLower()]; }
            set { Parameters[nameof(IopsReadRate).ToLower()] = value; }
        }

        /// <summary>
        /// io requests write rate of the disk offering
        /// </summary>
        public long? IopsWriteRate {
            get { return (long?) Parameters[nameof(IopsWriteRate).ToLower()]; }
            set { Parameters[nameof(IopsWriteRate).ToLower()] = value; }
        }

        /// <summary>
        /// max iops of the disk offering
        /// </summary>
        public long? MaxIops {
            get { return (long?) Parameters[nameof(MaxIops).ToLower()]; }
            set { Parameters[nameof(MaxIops).ToLower()] = value; }
        }

        /// <summary>
        /// min iops of the disk offering
        /// </summary>
        public long? MinIops {
            get { return (long?) Parameters[nameof(MinIops).ToLower()]; }
            set { Parameters[nameof(MinIops).ToLower()] = value; }
        }

        /// <summary>
        /// provisioning type used to create volumes. Valid values are thin, sparse, fat.
        /// </summary>
        public string ProvisioningType {
            get { return (string) Parameters[nameof(ProvisioningType).ToLower()]; }
            set { Parameters[nameof(ProvisioningType).ToLower()] = value; }
        }

        /// <summary>
        /// the storage type of the disk offering. Values are local and shared.
        /// </summary>
        public string StorageType {
            get { return (string) Parameters[nameof(StorageType).ToLower()]; }
            set { Parameters[nameof(StorageType).ToLower()] = value; }
        }

        /// <summary>
        /// tags for the disk offering
        /// </summary>
        public string Tags {
            get { return (string) Parameters[nameof(Tags).ToLower()]; }
            set { Parameters[nameof(Tags).ToLower()] = value; }
        }

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
