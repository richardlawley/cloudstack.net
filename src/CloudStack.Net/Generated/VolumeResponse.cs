using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class VolumeResponse
    {
        /// <summary>
        /// ID of the disk volume
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the account associated with the disk volume
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// the date the volume was attached to a VM instance
        /// </summary>
        public DateTime Attached { get; set; }

        /// <summary>
        /// the chain info of the volume
        /// </summary>
        public string ChainInfo { get; set; }

        /// <summary>
        /// the date the disk volume was created
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// the boolean state of whether the volume is destroyed or not
        /// </summary>
        public bool Destroyed { get; set; }

        /// <summary>
        /// the ID of the device on user vm the volume is attahed to. This tag is not returned when the volume is detached.
        /// </summary>
        public long DeviceId { get; set; }

        /// <summary>
        /// bytes read rate of the disk volume
        /// </summary>
        public long DiskBytesReadRate { get; set; }

        /// <summary>
        /// bytes write rate of the disk volume
        /// </summary>
        public long DiskBytesWriteRate { get; set; }

        /// <summary>
        /// io requests read rate of the disk volume
        /// </summary>
        public long DiskIopsReadRate { get; set; }

        /// <summary>
        /// io requests write rate of the disk volume
        /// </summary>
        public long DiskIopsWriteRate { get; set; }

        /// <summary>
        /// the display text of the disk offering
        /// </summary>
        public string DiskOfferingDisplayText { get; set; }

        /// <summary>
        /// ID of the disk offering
        /// </summary>
        public string DiskOfferingId { get; set; }

        /// <summary>
        /// name of the disk offering
        /// </summary>
        public string DiskOfferingName { get; set; }

        /// <summary>
        /// an optional field whether to the display the volume to the end user or not.
        /// </summary>
        public bool DisplayVolume { get; set; }

        /// <summary>
        /// the domain associated with the disk volume
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the ID of the domain associated with the disk volume
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// Hypervisor the volume belongs to
        /// </summary>
        public string Hypervisor { get; set; }

        /// <summary>
        /// true if the volume is extractable, false otherwise
        /// </summary>
        public bool Isextractable { get; set; }

        /// <summary>
        /// an alternate display text of the ISO attached to the virtual machine
        /// </summary>
        public string IsoDisplayText { get; set; }

        /// <summary>
        /// the ID of the ISO attached to the virtual machine
        /// </summary>
        public string IsoId { get; set; }

        /// <summary>
        /// the name of the ISO attached to the virtual machine
        /// </summary>
        public string IsoName { get; set; }

        /// <summary>
        /// max iops of the disk volume
        /// </summary>
        public long MaxIops { get; set; }

        /// <summary>
        /// min iops of the disk volume
        /// </summary>
        public long MinIops { get; set; }

        /// <summary>
        /// name of the disk volume
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the path of the volume
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// the project name of the vpn
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// the project id of the vpn
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// provisioning type used to create volumes.
        /// </summary>
        public string ProvisioningType { get; set; }

        /// <summary>
        /// need quiesce vm or not when taking snapshot
        /// </summary>
        public bool Quiescevm { get; set; }

        /// <summary>
        /// the display text of the service offering for root disk
        /// </summary>
        public string ServiceOfferingDisplayText { get; set; }

        /// <summary>
        /// ID of the service offering for root disk
        /// </summary>
        public string ServiceOfferingId { get; set; }

        /// <summary>
        /// name of the service offering for root disk
        /// </summary>
        public string ServiceOfferingName { get; set; }

        /// <summary>
        /// size of the disk volume
        /// </summary>
        public long Size { get; set; }

        /// <summary>
        /// ID of the snapshot from which this volume was created
        /// </summary>
        public string SnapshotId { get; set; }

        /// <summary>
        /// the state of the disk volume
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// the status of the volume
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// name of the primary storage hosting the disk volume
        /// </summary>
        public string Storage { get; set; }

        /// <summary>
        /// id of the primary storage hosting the disk volume; returned to admin user only
        /// </summary>
        public string Storageid { get; set; }

        /// <summary>
        /// shared or local storage
        /// </summary>
        public string StorageType { get; set; }

        /// <summary>
        ///  an alternate display text of the template for the virtual machine
        /// </summary>
        public string TemplateDisplayText { get; set; }

        /// <summary>
        /// the ID of the template for the virtual machine. A -1 is returned if the virtual machine was created from an ISO file.
        /// </summary>
        public string TemplateId { get; set; }

        /// <summary>
        /// the name of the template for the virtual machine
        /// </summary>
        public string TemplateName { get; set; }

        /// <summary>
        /// type of the disk volume (ROOT or DATADISK)
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// id of the virtual machine
        /// </summary>
        public string VirtualMachineId { get; set; }

        /// <summary>
        /// display name of the virtual machine
        /// </summary>
        public string Vmdisplayname { get; set; }

        /// <summary>
        /// name of the virtual machine
        /// </summary>
        public string Vmname { get; set; }

        /// <summary>
        /// state of the virtual machine
        /// </summary>
        public string Vmstate { get; set; }

        /// <summary>
        /// ID of the availability zone
        /// </summary>
        public string ZoneId { get; set; }

        /// <summary>
        /// name of the availability zone
        /// </summary>
        public string ZoneName { get; set; }

        /// <summary>
        /// the list of resource tags associated with volume
        /// </summary>
        public IList<ResourceTagResponse> Tags { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
