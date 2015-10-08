using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateStoragePoolRequest : APIRequest
    {
        public UpdateStoragePoolRequest() : base("updateStoragePool") {}

        /// <summary>
        /// the Id of the storage pool
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// bytes CloudStack can provision from this storage pool
        /// </summary>
        public long? CapacityBytes { get; set; }

        /// <summary>
        /// IOPS CloudStack can provision from this storage pool
        /// </summary>
        public long? CapacityIops { get; set; }

        /// <summary>
        /// false to disable the pool for allocation of new volumes, true to enable it back.
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// comma-separated list of tags for the storage pool
        /// </summary>
        public IList<string> Tags { get; set; }

    }
    /// <summary>
    /// Updates a storage pool.
    /// </summary>
    /// <summary>
    /// Updates a storage pool.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        StoragePoolResponse UpdateStoragePool(UpdateStoragePoolRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public StoragePoolResponse UpdateStoragePool(UpdateStoragePoolRequest request) => _proxy.Request<StoragePoolResponse>(request);
    }
}
