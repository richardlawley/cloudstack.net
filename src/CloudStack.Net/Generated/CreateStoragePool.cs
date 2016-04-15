using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateStoragePoolRequest : APIRequest
    {
        public CreateStoragePoolRequest() : base("createStoragePool") {}

        /// <summary>
        /// the name for the storage pool
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// the URL of the storage pool
        /// </summary>
        public string Url {
            get { return GetParameterValue<string>(nameof(Url).ToLower()); }
            set { SetParameterValue(nameof(Url).ToLower(), value); }
        }

        /// <summary>
        /// the Zone ID for the storage pool
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
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
        /// the cluster ID for the storage pool
        /// </summary>
        public Guid ClusterId {
            get { return GetParameterValue<Guid>(nameof(ClusterId).ToLower()); }
            set { SetParameterValue(nameof(ClusterId).ToLower(), value); }
        }

        /// <summary>
        /// the details for the storage pool
        /// </summary>
        public IList<IDictionary<string, object>> Details {
            get { return GetList<IDictionary<string, object>>(nameof(Details).ToLower()); }
            set { SetParameterValue(nameof(Details).ToLower(), value); }
        }

        /// <summary>
        /// hypervisor type of the hosts in zone that will be attached to this storage pool. KVM, VMware supported as of now.
        /// </summary>
        public string Hypervisor {
            get { return GetParameterValue<string>(nameof(Hypervisor).ToLower()); }
            set { SetParameterValue(nameof(Hypervisor).ToLower(), value); }
        }

        /// <summary>
        /// whether the storage should be managed by CloudStack
        /// </summary>
        public bool? Managed {
            get { return GetParameterValue<bool?>(nameof(Managed).ToLower()); }
            set { SetParameterValue(nameof(Managed).ToLower(), value); }
        }

        /// <summary>
        /// the Pod ID for the storage pool
        /// </summary>
        public Guid PodId {
            get { return GetParameterValue<Guid>(nameof(PodId).ToLower()); }
            set { SetParameterValue(nameof(PodId).ToLower(), value); }
        }

        /// <summary>
        /// the storage provider name
        /// </summary>
        public string Provider {
            get { return GetParameterValue<string>(nameof(Provider).ToLower()); }
            set { SetParameterValue(nameof(Provider).ToLower(), value); }
        }

        /// <summary>
        /// the scope of the storage: cluster or zone
        /// </summary>
        public string Scope {
            get { return GetParameterValue<string>(nameof(Scope).ToLower()); }
            set { SetParameterValue(nameof(Scope).ToLower(), value); }
        }

        /// <summary>
        /// the tags for the storage pool
        /// </summary>
        public string Tags {
            get { return GetParameterValue<string>(nameof(Tags).ToLower()); }
            set { SetParameterValue(nameof(Tags).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates a storage pool.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        StoragePoolResponse CreateStoragePool(CreateStoragePoolRequest request);
        Task<StoragePoolResponse> CreateStoragePoolAsync(CreateStoragePoolRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public StoragePoolResponse CreateStoragePool(CreateStoragePoolRequest request) => _proxy.Request<StoragePoolResponse>(request);
        public Task<StoragePoolResponse> CreateStoragePoolAsync(CreateStoragePoolRequest request) => _proxy.RequestAsync<StoragePoolResponse>(request);
    }
}
