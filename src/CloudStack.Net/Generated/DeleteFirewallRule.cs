using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteFirewallRuleRequest : APIRequest
    {
        public DeleteFirewallRuleRequest() : base("deleteFirewallRule") {}

        /// <summary>
        /// the ID of the firewall rule
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Deletes a firewall rule
    /// </summary>
    /// <summary>
    /// Deletes a firewall rule
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteFirewallRule(DeleteFirewallRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteFirewallRule(DeleteFirewallRuleRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
