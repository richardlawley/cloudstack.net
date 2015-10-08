using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DissociateLunRequest : APIRequest
    {
        public DissociateLunRequest() : base("dissociateLun") {}

        /// <summary>
        /// Guest IQN.
        /// </summary>
        public string GuestIQN { get; set; }

        /// <summary>
        /// LUN path.
        /// </summary>
        public string Path { get; set; }

    }
    /// <summary>
    /// Dissociate a LUN
    /// </summary>
    /// <summary>
    /// Dissociate a LUN
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        DissociateLunCmdResponse DissociateLun(DissociateLunRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public DissociateLunCmdResponse DissociateLun(DissociateLunRequest request) => _proxy.Request<DissociateLunCmdResponse>(request);
    }
}
