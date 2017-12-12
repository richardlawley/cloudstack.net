using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeletePoolRequest : APIRequest
    {
        public DeletePoolRequest() : base("deletePool") {}

        /// <summary>
        /// pool name.
        /// </summary>
        public string PoolName {
            get { return GetParameterValue<string>(nameof(PoolName).ToLower()); }
            set { SetParameterValue(nameof(PoolName).ToLower(), value); }
        }

    }
    /// <summary>
    /// Delete a pool
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        DeleteVolumePoolCmdResponse DeletePool(DeletePoolRequest request);
        Task<DeleteVolumePoolCmdResponse> DeletePoolAsync(DeletePoolRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public DeleteVolumePoolCmdResponse DeletePool(DeletePoolRequest request) => Proxy.Request<DeleteVolumePoolCmdResponse>(request);
        public Task<DeleteVolumePoolCmdResponse> DeletePoolAsync(DeletePoolRequest request) => Proxy.RequestAsync<DeleteVolumePoolCmdResponse>(request);
    }
}
