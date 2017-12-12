using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreatePoolRequest : APIRequest
    {
        public CreatePoolRequest() : base("createPool") {}

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
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

    }
    /// <summary>
    /// Create a pool
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        CreateVolumePoolCmdResponse CreatePool(CreatePoolRequest request);
        Task<CreateVolumePoolCmdResponse> CreatePoolAsync(CreatePoolRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public CreateVolumePoolCmdResponse CreatePool(CreatePoolRequest request) => Proxy.Request<CreateVolumePoolCmdResponse>(request);
        public Task<CreateVolumePoolCmdResponse> CreatePoolAsync(CreatePoolRequest request) => Proxy.RequestAsync<CreateVolumePoolCmdResponse>(request);
    }
}
