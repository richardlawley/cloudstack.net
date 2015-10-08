using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class FindStoragePoolsForMigrationRequest : APIRequest
    {
        public FindStoragePoolsForMigrationRequest() : base("findStoragePoolsForMigration") {}

        /// <summary>
        /// the ID of the volume
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

    }
    /// <summary>
    /// Lists storage pools available for migration of a volume.
    /// </summary>
    /// <summary>
    /// Lists storage pools available for migration of a volume.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<StoragePoolResponse> FindStoragePoolsForMigration(FindStoragePoolsForMigrationRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<StoragePoolResponse> FindStoragePoolsForMigration(FindStoragePoolsForMigrationRequest request) => _proxy.Request<ListResponse<StoragePoolResponse>>(request);
    }
}
