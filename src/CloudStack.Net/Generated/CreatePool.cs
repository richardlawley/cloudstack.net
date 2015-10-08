using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreatePoolRequest : APIRequest
    {
        public CreatePoolRequest() : base("createPool") {}

        /// <summary>
        /// algorithm.
        /// </summary>
        public string Algorithm { get; set; }

        /// <summary>
        /// pool name.
        /// </summary>
        public string PoolName { get; set; }

    }
    /// <summary>
    /// Create a pool
    /// </summary>
    /// <summary>
    /// Create a pool
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        CreateVolumePoolCmdResponse CreatePool(CreatePoolRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public CreateVolumePoolCmdResponse CreatePool(CreatePoolRequest request) => _proxy.Request<CreateVolumePoolCmdResponse>(request);
    }
}
