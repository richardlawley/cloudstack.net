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
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
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
        public ListResponse<StoragePoolResponse> FindStoragePoolsForMigration(FindStoragePoolsForMigrationRequest request) => Proxy.Request<ListResponse<StoragePoolResponse>>(request);
        public Task<ListResponse<StoragePoolResponse>> FindStoragePoolsForMigrationAsync(FindStoragePoolsForMigrationRequest request) => Proxy.RequestAsync<ListResponse<StoragePoolResponse>>(request);
        public ListResponse<StoragePoolResponse> FindStoragePoolsForMigrationAllPages(FindStoragePoolsForMigrationRequest request) => Proxy.RequestAllPages<StoragePoolResponse>(request);
        public Task<ListResponse<StoragePoolResponse>> FindStoragePoolsForMigrationAllPagesAsync(FindStoragePoolsForMigrationRequest request) => Proxy.RequestAllPagesAsync<StoragePoolResponse>(request);
    }
}
