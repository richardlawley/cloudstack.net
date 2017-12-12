using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// bytes CloudStack can provision from this storage pool
        /// </summary>
        public long? CapacityBytes {
            get { return GetParameterValue<long?>(nameof(CapacityBytes).ToLower()); }
            set { SetParameterValue(nameof(CapacityBytes).ToLower(), value); }
        }

        /// <summary>
        /// IOPS CloudStack can provision from this storage pool
        /// </summary>
        public long? CapacityIops {
            get { return GetParameterValue<long?>(nameof(CapacityIops).ToLower()); }
            set { SetParameterValue(nameof(CapacityIops).ToLower(), value); }
        }

        /// <summary>
        /// false to disable the pool for allocation of new volumes, true to enable it back.
        /// </summary>
        public bool? Enabled {
            get { return GetParameterValue<bool?>(nameof(Enabled).ToLower()); }
            set { SetParameterValue(nameof(Enabled).ToLower(), value); }
        }

        /// <summary>
        /// comma-separated list of tags for the storage pool
        /// </summary>
        public IList<string> Tags {
            get { return GetList<string>(nameof(Tags).ToLower()); }
            set { SetParameterValue(nameof(Tags).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates a storage pool.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        StoragePoolResponse UpdateStoragePool(UpdateStoragePoolRequest request);
        Task<StoragePoolResponse> UpdateStoragePoolAsync(UpdateStoragePoolRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public StoragePoolResponse UpdateStoragePool(UpdateStoragePoolRequest request) => Proxy.Request<StoragePoolResponse>(request);
        public Task<StoragePoolResponse> UpdateStoragePoolAsync(UpdateStoragePoolRequest request) => Proxy.RequestAsync<StoragePoolResponse>(request);
    }
}
