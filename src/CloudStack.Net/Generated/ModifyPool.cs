using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<string>(nameof(Algorithm).ToLower()); }
            set { SetParameterValue(nameof(Algorithm).ToLower(), value); }
        }

        /// <summary>
        /// pool name.
        /// </summary>
        public string PoolName {
            get { return GetParameterValue<string>(nameof(PoolName).ToLower()); }
            set { SetParameterValue(nameof(PoolName).ToLower(), value); }
        }

    }
    /// <summary>
    /// Modify pool
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ModifyVolumePoolCmdResponse ModifyPool(ModifyPoolRequest request);
        Task<ModifyVolumePoolCmdResponse> ModifyPoolAsync(ModifyPoolRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ModifyVolumePoolCmdResponse ModifyPool(ModifyPoolRequest request) => Proxy.Request<ModifyVolumePoolCmdResponse>(request);
        public Task<ModifyVolumePoolCmdResponse> ModifyPoolAsync(ModifyPoolRequest request) => Proxy.RequestAsync<ModifyVolumePoolCmdResponse>(request);
    }
}
