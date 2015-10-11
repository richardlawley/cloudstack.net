using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class MigrateVolumeRequest : APIRequest
    {
        public MigrateVolumeRequest() : base("migrateVolume") {}

        /// <summary>
        /// destination storage pool ID to migrate the volume to
        /// </summary>
        public Guid StorageId {
            get { return (Guid) Parameters[nameof(StorageId).ToLower()]; }
            set { Parameters[nameof(StorageId).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the volume
        /// </summary>
        public Guid VolumeId {
            get { return (Guid) Parameters[nameof(VolumeId).ToLower()]; }
            set { Parameters[nameof(VolumeId).ToLower()] = value; }
        }

        /// <summary>
        /// if the volume should be live migrated when it is attached to a running vm
        /// </summary>
        public bool? LiveMigrate {
            get { return (bool?) Parameters[nameof(LiveMigrate).ToLower()]; }
            set { Parameters[nameof(LiveMigrate).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Migrate volume
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse MigrateVolume(MigrateVolumeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse MigrateVolume(MigrateVolumeRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
