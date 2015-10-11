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
        public Guid ClusterId {
            get { return (Guid) Parameters[nameof(ClusterId).ToLower()]; }
            set { Parameters[nameof(ClusterId).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the storage pool
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// the IP address for the storage pool
        /// </summary>
        public string IpAddress {
            get { return (string) Parameters[nameof(IpAddress).ToLower()]; }
            set { Parameters[nameof(IpAddress).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        /// <summary>
        /// the name of the storage pool
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        public int? Page {
            get { return (int?) Parameters[nameof(Page).ToLower()]; }
            set { Parameters[nameof(Page).ToLower()] = value; }
        }

        public int? PageSize {
            get { return (int?) Parameters[nameof(PageSize).ToLower()]; }
            set { Parameters[nameof(PageSize).ToLower()] = value; }
        }

        /// <summary>
        /// the storage pool path
        /// </summary>
        public string Path {
            get { return (string) Parameters[nameof(Path).ToLower()]; }
            set { Parameters[nameof(Path).ToLower()] = value; }
        }

        /// <summary>
        /// the Pod ID for the storage pool
        /// </summary>
        public Guid PodId {
            get { return (Guid) Parameters[nameof(PodId).ToLower()]; }
            set { Parameters[nameof(PodId).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the storage pool
        /// </summary>
        public string Scope {
            get { return (string) Parameters[nameof(Scope).ToLower()]; }
            set { Parameters[nameof(Scope).ToLower()] = value; }
        }

        /// <summary>
        /// the Zone ID for the storage pool
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

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
