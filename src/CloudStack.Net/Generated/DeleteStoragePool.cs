using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteStoragePoolRequest : APIRequest
    {
        public DeleteStoragePoolRequest() : base("deleteStoragePool") {}

        /// <summary>
        /// Storage pool id
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// Force destroy storage pool (force expunge volumes in Destroyed state as a part of pool removal)
        /// </summary>
        public bool? Forced {
            get { return (bool?) Parameters[nameof(Forced).ToLower()]; }
            set { Parameters[nameof(Forced).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Deletes a storage pool.
    /// </summary>
    /// <summary>
    /// Deletes a storage pool.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteStoragePool(DeleteStoragePoolRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteStoragePool(DeleteStoragePoolRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
