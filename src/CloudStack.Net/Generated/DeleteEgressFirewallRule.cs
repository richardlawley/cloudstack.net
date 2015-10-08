using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteEgressFirewallRuleRequest : APIRequest
    {
        public DeleteEgressFirewallRuleRequest() : base("deleteEgressFirewallRule") {}

        /// <summary>
        /// the ID of the firewall rule
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Deletes an egress firewall rule
    /// </summary>
    /// <summary>
    /// Deletes an egress firewall rule
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteEgressFirewallRule(DeleteEgressFirewallRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteEgressFirewallRule(DeleteEgressFirewallRuleRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
