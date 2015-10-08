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
        public Guid StorageId { get; set; }

        /// <summary>
        /// the ID of the volume
        /// </summary>
        public Guid VolumeId { get; set; }

        /// <summary>
        /// if the volume should be live migrated when it is attached to a running vm
        /// </summary>
        public bool? LiveMigrate { get; set; }

    }
    /// <summary>
    /// Migrate volume
    /// </summary>
    /// <summary>
    /// Migrate volume
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        VolumeResponse MigrateVolume(MigrateVolumeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public VolumeResponse MigrateVolume(MigrateVolumeRequest request) => _proxy.Request<VolumeResponse>(request);
    }
}
