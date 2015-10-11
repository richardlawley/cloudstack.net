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
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// the URL of the storage pool
        /// </summary>
        public string Url {
            get { return (string) Parameters[nameof(Url).ToLower()]; }
            set { Parameters[nameof(Url).ToLower()] = value; }
        }

        /// <summary>
        /// the Zone ID for the storage pool
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
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
        /// the cluster ID for the storage pool
        /// </summary>
        public Guid ClusterId {
            get { return (Guid) Parameters[nameof(ClusterId).ToLower()]; }
            set { Parameters[nameof(ClusterId).ToLower()] = value; }
        }

        /// <summary>
        /// the details for the storage pool
        /// </summary>
        public IDictionary<string, string> Details {
            get { return (IDictionary<string, string>) Parameters[nameof(Details).ToLower()]; }
            set { Parameters[nameof(Details).ToLower()] = value; }
        }

        /// <summary>
        /// hypervisor type of the hosts in zone that will be attached to this storage pool. KVM, VMware supported as of now.
        /// </summary>
        public string Hypervisor {
            get { return (string) Parameters[nameof(Hypervisor).ToLower()]; }
            set { Parameters[nameof(Hypervisor).ToLower()] = value; }
        }

        /// <summary>
        /// whether the storage should be managed by CloudStack
        /// </summary>
        public bool? Managed {
            get { return (bool?) Parameters[nameof(Managed).ToLower()]; }
            set { Parameters[nameof(Managed).ToLower()] = value; }
        }

        /// <summary>
        /// the Pod ID for the storage pool
        /// </summary>
        public Guid PodId {
            get { return (Guid) Parameters[nameof(PodId).ToLower()]; }
            set { Parameters[nameof(PodId).ToLower()] = value; }
        }

        /// <summary>
        /// the storage provider name
        /// </summary>
        public string Provider {
            get { return (string) Parameters[nameof(Provider).ToLower()]; }
            set { Parameters[nameof(Provider).ToLower()] = value; }
        }

        /// <summary>
        /// the scope of the storage: cluster or zone
        /// </summary>
        public string Scope {
            get { return (string) Parameters[nameof(Scope).ToLower()]; }
            set { Parameters[nameof(Scope).ToLower()] = value; }
        }

        /// <summary>
        /// the tags for the storage pool
        /// </summary>
        public string Tags {
            get { return (string) Parameters[nameof(Tags).ToLower()]; }
            set { Parameters[nameof(Tags).ToLower()] = value; }
        }

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
