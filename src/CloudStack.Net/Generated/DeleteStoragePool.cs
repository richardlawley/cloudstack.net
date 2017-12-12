using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// Force destroy storage pool (force expunge volumes in Destroyed state as a part of pool removal)
        /// </summary>
        public bool? Forced {
            get { return GetParameterValue<bool?>(nameof(Forced).ToLower()); }
            set { SetParameterValue(nameof(Forced).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a storage pool.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteStoragePool(DeleteStoragePoolRequest request);
        Task<SuccessResponse> DeleteStoragePoolAsync(DeleteStoragePoolRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteStoragePool(DeleteStoragePoolRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteStoragePoolAsync(DeleteStoragePoolRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
