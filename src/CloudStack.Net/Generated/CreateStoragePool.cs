using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateStoragePoolRequest : APIRequest
    {
        public CreateStoragePoolRequest() : base("createStoragePool") {}

        /// <summary>
        /// the name for the storage pool
        /// </summary>
        public string StoragePoolName { get; set; }

        /// <summary>
        /// the URL of the storage pool
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// the Zone ID for the storage pool
        /// </summary>
        public Guid ZoneId { get; set; }

        /// <summary>
        /// bytes CloudStack can provision from this storage pool
        /// </summary>
        public long? CapacityBytes { get; set; }

        /// <summary>
        /// IOPS CloudStack can provision from this storage pool
        /// </summary>
        public long? CapacityIops { get; set; }

        /// <summary>
        /// the cluster ID for the storage pool
        /// </summary>
        public Guid ClusterId { get; set; }

        /// <summary>
        /// the details for the storage pool
        /// </summary>
        public IDictionary<string, string> Details { get; set; }

        /// <summary>
        /// hypervisor type of the hosts in zone that will be attached to this storage pool. KVM, VMware supported as of now.
        /// </summary>
        public string Hypervisor { get; set; }

        /// <summary>
        /// whether the storage should be managed by CloudStack
        /// </summary>
        public bool? Managed { get; set; }

        /// <summary>
        /// the Pod ID for the storage pool
        /// </summary>
        public Guid PodId { get; set; }

        /// <summary>
        /// the storage provider name
        /// </summary>
        public string StorageProviderName { get; set; }

        /// <summary>
        /// the scope of the storage: cluster or zone
        /// </summary>
        public string Scope { get; set; }

        /// <summary>
        /// the tags for the storage pool
        /// </summary>
        public string Tags { get; set; }

    }
    /// <summary>
    /// Creates a storage pool.
    /// </summary>
    /// <summary>
    /// Creates a storage pool.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        StoragePoolResponse CreateStoragePool(CreateStoragePoolRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public StoragePoolResponse CreateStoragePool(CreateStoragePoolRequest request) => _proxy.Request<StoragePoolResponse>(request);
    }
}
