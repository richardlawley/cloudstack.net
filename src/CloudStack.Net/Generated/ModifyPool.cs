using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ModifyPoolRequest : APIRequest
    {
        public ModifyPoolRequest() : base("modifyPool") {}

        /// <summary>
        /// algorithm.
        /// </summary>
        public string Algorithm {
            get { return (string) Parameters[nameof(Algorithm).ToLower()]; }
            set { Parameters[nameof(Algorithm).ToLower()] = value; }
        }

        /// <summary>
        /// pool name.
        /// </summary>
        public string PoolName {
            get { return (string) Parameters[nameof(PoolName).ToLower()]; }
            set { Parameters[nameof(PoolName).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Modify pool
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ModifyVolumePoolCmdResponse ModifyPool(ModifyPoolRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ModifyVolumePoolCmdResponse ModifyPool(ModifyPoolRequest request) => _proxy.Request<ModifyVolumePoolCmdResponse>(request);
    }
}
