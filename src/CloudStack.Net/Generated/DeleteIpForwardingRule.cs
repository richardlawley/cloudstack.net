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
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Deletes an IP forwarding rule
    /// </summary>
    /// <summary>
    /// Deletes an IP forwarding rule
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteIpForwardingRule(DeleteIpForwardingRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteIpForwardingRule(DeleteIpForwardingRuleRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
