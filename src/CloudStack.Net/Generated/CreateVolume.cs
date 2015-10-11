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
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// the account associated with the disk volume. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId {
            get { return (string) Parameters[nameof(CustomId).ToLower()]; }
            set { Parameters[nameof(CustomId).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the disk offering. Either diskOfferingId or snapshotId must be passed in.
        /// </summary>
        public Guid DiskOfferingId {
            get { return (Guid) Parameters[nameof(DiskOfferingId).ToLower()]; }
            set { Parameters[nameof(DiskOfferingId).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, whether to display the volume to the end user or not.
        /// </summary>
        public bool? DisplayVolume {
            get { return (bool?) Parameters[nameof(DisplayVolume).ToLower()]; }
            set { Parameters[nameof(DisplayVolume).ToLower()] = value; }
        }

        /// <summary>
        /// the domain ID associated with the disk offering. If used with the account parameter returns the disk volume associated with the account for the specified domain.
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// max iops
        /// </summary>
        public long? MaxIops {
            get { return (long?) Parameters[nameof(MaxIops).ToLower()]; }
            set { Parameters[nameof(MaxIops).ToLower()] = value; }
        }

        /// <summary>
        /// min iops
        /// </summary>
        public long? MinIops {
            get { return (long?) Parameters[nameof(MinIops).ToLower()]; }
            set { Parameters[nameof(MinIops).ToLower()] = value; }
        }

        /// <summary>
        /// the project associated with the volume. Mutually exclusive with account parameter
        /// </summary>
        public Guid ProjectId {
            get { return (Guid) Parameters[nameof(ProjectId).ToLower()]; }
            set { Parameters[nameof(ProjectId).ToLower()] = value; }
        }

        /// <summary>
        /// Arbitrary volume size
        /// </summary>
        public long? Size {
            get { return (long?) Parameters[nameof(Size).ToLower()]; }
            set { Parameters[nameof(Size).ToLower()] = value; }
        }

        /// <summary>
        /// the snapshot ID for the disk volume. Either diskOfferingId or snapshotId must be passed in.
        /// </summary>
        public Guid SnapshotId {
            get { return (Guid) Parameters[nameof(SnapshotId).ToLower()]; }
            set { Parameters[nameof(SnapshotId).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the virtual machine; to be used with snapshot Id, VM to which the volume gets attached after creation
        /// </summary>
        public Guid VirtualMachineId {
            get { return (Guid) Parameters[nameof(VirtualMachineId).ToLower()]; }
            set { Parameters[nameof(VirtualMachineId).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the availability zone
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

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
