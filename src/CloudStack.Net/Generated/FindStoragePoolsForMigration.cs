using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class FindStoragePoolsForMigrationRequest : APIListRequest
    {
        public FindStoragePoolsForMigrationRequest() : base("findStoragePoolsForMigration") {}

        /// <summary>
        /// the ID of the volume
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists storage pools available for migration of a volume.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<StoragePoolResponse> FindStoragePoolsForMigration(FindStoragePoolsForMigrationRequest request);
        Task<ListResponse<StoragePoolResponse>> FindStoragePoolsForMigrationAsync(FindStoragePoolsForMigrationRequest request);
        ListResponse<StoragePoolResponse> FindStoragePoolsForMigrationAllPages(FindStoragePoolsForMigrationRequest request);
        Task<ListResponse<StoragePoolResponse>> FindStoragePoolsForMigrationAllPagesAsync(FindStoragePoolsForMigrationRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<StoragePoolResponse> FindStoragePoolsForMigration(FindStoragePoolsForMigrationRequest request) => _proxy.Request<ListResponse<StoragePoolResponse>>(request);
        public Task<ListResponse<StoragePoolResponse>> FindStoragePoolsForMigrationAsync(FindStoragePoolsForMigrationRequest request) => _proxy.RequestAsync<ListResponse<StoragePoolResponse>>(request);
        public ListResponse<StoragePoolResponse> FindStoragePoolsForMigrationAllPages(FindStoragePoolsForMigrationRequest request) => _proxy.RequestAllPages<StoragePoolResponse>(request);
        public Task<ListResponse<StoragePoolResponse>> FindStoragePoolsForMigrationAllPagesAsync(FindStoragePoolsForMigrationRequest request) => _proxy.RequestAllPagesAsync<StoragePoolResponse>(request);
    }
}
