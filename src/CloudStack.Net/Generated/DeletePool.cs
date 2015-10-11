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
        public string PoolName {
            get { return (string) Parameters[nameof(PoolName).ToLower()]; }
            set { Parameters[nameof(PoolName).ToLower()] = value; }
        }

    }
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
