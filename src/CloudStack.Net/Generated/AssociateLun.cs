using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AssociateLunRequest : APIRequest
    {
        public AssociateLunRequest() : base("associateLun") {}

        /// <summary>
        /// Guest IQN to which the LUN associate.
        /// </summary>
        public string GuestIqn { get; set; }

        /// <summary>
        /// LUN name.
        /// </summary>
        public string LunName { get; set; }

    }
    /// <summary>
    /// Associate a LUN with a guest IQN
    /// </summary>
    /// <summary>
    /// Associate a LUN with a guest IQN
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AssociateLunCmdResponse AssociateLun(AssociateLunRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AssociateLunCmdResponse AssociateLun(AssociateLunRequest request) => _proxy.Request<AssociateLunCmdResponse>(request);
    }
}
