using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateFirewallRuleRequest : APIRequest
    {
        public UpdateFirewallRuleRequest() : base("updateFirewallRule") {}

        /// <summary>
        /// the ID of the firewall rule
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId { get; set; }

        /// <summary>
        /// an optional field, whether to the display the rule to the end user or not
        /// </summary>
        public bool? Display { get; set; }

    }
    /// <summary>
    /// Updates firewall rule 
    /// </summary>
    /// <summary>
    /// Updates firewall rule 
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        FirewallResponse UpdateFirewallRule(UpdateFirewallRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public FirewallResponse UpdateFirewallRule(UpdateFirewallRuleRequest request) => _proxy.Request<FirewallResponse>(request);
    }
}
