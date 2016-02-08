using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AssociateLunRequest : APIRequest
    {
        public AssociateLunRequest() : base("associateLun") {}

        /// <summary>
        /// Guest IQN to which the LUN associate.
        /// </summary>
        public string Iqn {
            get { return (string) Parameters[nameof(Iqn).ToLower()]; }
            set { Parameters[nameof(Iqn).ToLower()] = value; }
        }

        /// <summary>
        /// LUN name.
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Associate a LUN with a guest IQN
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AssociateLunCmdResponse AssociateLun(AssociateLunRequest request);
        Task<AssociateLunCmdResponse> AssociateLunAsync(AssociateLunRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AssociateLunCmdResponse AssociateLun(AssociateLunRequest request) => _proxy.Request<AssociateLunCmdResponse>(request);
        public Task<AssociateLunCmdResponse> AssociateLunAsync(AssociateLunRequest request) => _proxy.RequestAsync<AssociateLunCmdResponse>(request);
    }
}
