using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteIpForwardingRuleRequest : APIRequest
    {
        public DeleteIpForwardingRuleRequest() : base("deleteIpForwardingRule") {}

        /// <summary>
        /// the ID of the forwarding rule
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Deletes an IP forwarding rule
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteIpForwardingRule(DeleteIpForwardingRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteIpForwardingRule(DeleteIpForwardingRuleRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
