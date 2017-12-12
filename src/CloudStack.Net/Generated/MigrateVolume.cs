using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(StorageId).ToLower()); }
            set { SetParameterValue(nameof(StorageId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the volume
        /// </summary>
        public Guid VolumeId {
            get { return GetParameterValue<Guid>(nameof(VolumeId).ToLower()); }
            set { SetParameterValue(nameof(VolumeId).ToLower(), value); }
        }

        /// <summary>
        /// if the volume should be live migrated when it is attached to a running vm
        /// </summary>
        public bool? LiveMigrate {
            get { return GetParameterValue<bool?>(nameof(LiveMigrate).ToLower()); }
            set { SetParameterValue(nameof(LiveMigrate).ToLower(), value); }
        }

    }
    /// <summary>
    /// Migrate volume
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse MigrateVolume(MigrateVolumeRequest request);
        Task<AsyncJobResponse> MigrateVolumeAsync(MigrateVolumeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse MigrateVolume(MigrateVolumeRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> MigrateVolumeAsync(MigrateVolumeRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
