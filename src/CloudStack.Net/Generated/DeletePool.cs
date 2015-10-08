using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeletePoolRequest : APIRequest
    {
        public DeletePoolRequest() : base("deletePool") {}

        /// <summary>
        /// pool name.
        /// </summary>
        public string PoolName { get; set; }

    }
    /// <summary>
    /// Delete a pool
    /// </summary>
    /// <summary>
    /// Delete a pool
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        DeleteVolumePoolCmdResponse DeletePool(DeletePoolRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public DeleteVolumePoolCmdResponse DeletePool(DeletePoolRequest request) => _proxy.Request<DeleteVolumePoolCmdResponse>(request);
    }
}
