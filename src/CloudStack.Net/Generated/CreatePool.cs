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
        public string Algorithm {
            get { return (string) Parameters[nameof(Algorithm).ToLower()]; }
            set { Parameters[nameof(Algorithm).ToLower()] = value; }
        }

        /// <summary>
        /// pool name.
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

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
