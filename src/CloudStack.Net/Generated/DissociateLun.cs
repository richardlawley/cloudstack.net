using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DissociateLunRequest : APIRequest
    {
        public DissociateLunRequest() : base("dissociateLun") {}

        /// <summary>
        /// Guest IQN.
        /// </summary>
        public string Iqn {
            get { return (string) Parameters[nameof(Iqn).ToLower()]; }
            set { Parameters[nameof(Iqn).ToLower()] = value; }
        }

        /// <summary>
        /// LUN path.
        /// </summary>
        public string Path {
            get { return (string) Parameters[nameof(Path).ToLower()]; }
            set { Parameters[nameof(Path).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Dissociate a LUN
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        DissociateLunCmdResponse DissociateLun(DissociateLunRequest request);
        Task<DissociateLunCmdResponse> DissociateLunAsync(DissociateLunRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public DissociateLunCmdResponse DissociateLun(DissociateLunRequest request) => _proxy.Request<DissociateLunCmdResponse>(request);
        public Task<DissociateLunCmdResponse> DissociateLunAsync(DissociateLunRequest request) => _proxy.RequestAsync<DissociateLunCmdResponse>(request);
    }
}
