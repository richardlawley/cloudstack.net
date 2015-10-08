using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateVolumeRequest : APIRequest
    {
        public CreateVolumeRequest() : base("createVolume") {}

        /// <summary>
        /// the name of the disk volume
        /// </summary>
        public string VolumeName { get; set; }

        /// <summary>
        /// the account associated with the disk volume. Must be used with the domainId parameter.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId { get; set; }

        /// <summary>
        /// the ID of the disk offering. Either diskOfferingId or snapshotId must be passed in.
        /// </summary>
        public Guid DiskOfferingId { get; set; }

        /// <summary>
        /// an optional field, whether to display the volume to the end user or not.
        /// </summary>
        public bool? DisplayVolume { get; set; }

        /// <summary>
        /// the domain ID associated with the disk offering. If used with the account parameter returns the disk volume associated with the account for the specified domain.
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// max iops
        /// </summary>
        public long? MaxIops { get; set; }

        /// <summary>
        /// min iops
        /// </summary>
        public long? MinIops { get; set; }

        /// <summary>
        /// the project associated with the volume. Mutually exclusive with account parameter
        /// </summary>
        public Guid ProjectId { get; set; }

        /// <summary>
        /// Arbitrary volume size
        /// </summary>
        public long? Size { get; set; }

        /// <summary>
        /// the snapshot ID for the disk volume. Either diskOfferingId or snapshotId must be passed in.
        /// </summary>
        public Guid SnapshotId { get; set; }

        /// <summary>
        /// the ID of the virtual machine; to be used with snapshot Id, VM to which the volume gets attached after creation
        /// </summary>
        public Guid VirtualMachineId { get; set; }

        /// <summary>
        /// the ID of the availability zone
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// Creates a disk volume from a disk offering. This disk volume must still be attached to a virtual machine to make use of it.
    /// </summary>
    /// <summary>
    /// Creates a disk volume from a disk offering. This disk volume must still be attached to a virtual machine to make use of it.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        VolumeResponse CreateVolume(CreateVolumeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public VolumeResponse CreateVolume(CreateVolumeRequest request) => _proxy.Request<VolumeResponse>(request);
    }
}
