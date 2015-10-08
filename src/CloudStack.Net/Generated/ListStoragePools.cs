using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListStoragePoolsRequest : APIRequest
    {
        public ListStoragePoolsRequest() : base("listStoragePools") {}

        /// <summary>
        /// list storage pools belongig to the specific cluster
        /// </summary>
        public Guid ClusterId { get; set; }

        /// <summary>
        /// the ID of the storage pool
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// the IP address for the storage pool
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// the name of the storage pool
        /// </summary>
        public string StoragePoolName { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// the storage pool path
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// the Pod ID for the storage pool
        /// </summary>
        public Guid PodId { get; set; }

        /// <summary>
        /// the ID of the storage pool
        /// </summary>
        public string Scope { get; set; }

        /// <summary>
        /// the Zone ID for the storage pool
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// Lists storage pools.
    /// </summary>
    /// <summary>
    /// Lists storage pools.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<StoragePoolResponse> ListStoragePools(ListStoragePoolsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<StoragePoolResponse> ListStoragePools(ListStoragePoolsRequest request) => _proxy.Request<ListResponse<StoragePoolResponse>>(request);
    }
}
