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
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// bytes CloudStack can provision from this storage pool
        /// </summary>
        public long? CapacityBytes {
            get { return (long?) Parameters[nameof(CapacityBytes).ToLower()]; }
            set { Parameters[nameof(CapacityBytes).ToLower()] = value; }
        }

        /// <summary>
        /// IOPS CloudStack can provision from this storage pool
        /// </summary>
        public long? CapacityIops {
            get { return (long?) Parameters[nameof(CapacityIops).ToLower()]; }
            set { Parameters[nameof(CapacityIops).ToLower()] = value; }
        }

        /// <summary>
        /// false to disable the pool for allocation of new volumes, true to enable it back.
        /// </summary>
        public bool? Enabled {
            get { return (bool?) Parameters[nameof(Enabled).ToLower()]; }
            set { Parameters[nameof(Enabled).ToLower()] = value; }
        }

        /// <summary>
        /// comma-separated list of tags for the storage pool
        /// </summary>
        public IList<string> Tags {
            get { return GetList<string>(nameof(Tags).ToLower()); }
            set { Parameters[nameof(Tags).ToLower()] = value; }
        }

    }
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
