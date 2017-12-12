using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateVolumeRequest : APIRequest
    {
        public CreateVolumeRequest() : base("createVolume") {}

        /// <summary>
        /// the account associated with the disk volume. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId {
            get { return GetParameterValue<string>(nameof(CustomId).ToLower()); }
            set { SetParameterValue(nameof(CustomId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the disk offering. Either diskOfferingId or snapshotId must be passed in.
        /// </summary>
        public Guid? DiskOfferingId {
            get { return GetParameterValue<Guid?>(nameof(DiskOfferingId).ToLower()); }
            set { SetParameterValue(nameof(DiskOfferingId).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, whether to display the volume to the end user or not.
        /// </summary>
        public bool? DisplayVolume {
            get { return GetParameterValue<bool?>(nameof(DisplayVolume).ToLower()); }
            set { SetParameterValue(nameof(DisplayVolume).ToLower(), value); }
        }

        /// <summary>
        /// the domain ID associated with the disk offering. If used with the account parameter returns the disk volume associated with the account for the specified domain.
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// max iops
        /// </summary>
        public long? MaxIops {
            get { return GetParameterValue<long?>(nameof(MaxIops).ToLower()); }
            set { SetParameterValue(nameof(MaxIops).ToLower(), value); }
        }

        /// <summary>
        /// min iops
        /// </summary>
        public long? MinIops {
            get { return GetParameterValue<long?>(nameof(MinIops).ToLower()); }
            set { SetParameterValue(nameof(MinIops).ToLower(), value); }
        }

        /// <summary>
        /// the name of the disk volume
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// the project associated with the volume. Mutually exclusive with account parameter
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// Arbitrary volume size
        /// </summary>
        public long? Size {
            get { return GetParameterValue<long?>(nameof(Size).ToLower()); }
            set { SetParameterValue(nameof(Size).ToLower(), value); }
        }

        /// <summary>
        /// the snapshot ID for the disk volume. Either diskOfferingId or snapshotId must be passed in.
        /// </summary>
        public Guid? SnapshotId {
            get { return GetParameterValue<Guid?>(nameof(SnapshotId).ToLower()); }
            set { SetParameterValue(nameof(SnapshotId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the virtual machine; to be used with snapshot Id, VM to which the volume gets attached after creation
        /// </summary>
        public Guid? VirtualMachineId {
            get { return GetParameterValue<Guid?>(nameof(VirtualMachineId).ToLower()); }
            set { SetParameterValue(nameof(VirtualMachineId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the availability zone
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates a disk volume from a disk offering. This disk volume must still be attached to a virtual machine to make use of it.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateVolume(CreateVolumeRequest request);
        Task<AsyncJobResponse> CreateVolumeAsync(CreateVolumeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateVolume(CreateVolumeRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateVolumeAsync(CreateVolumeRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
