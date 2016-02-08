using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateEgressFirewallRuleRequest : APIRequest
    {
        public UpdateEgressFirewallRuleRequest() : base("updateEgressFirewallRule") {}

        /// <summary>
        /// the ID of the egress firewall rule
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId {
            get { return (string) Parameters[nameof(CustomId).ToLower()]; }
            set { Parameters[nameof(CustomId).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, whether to the display the rule to the end user or not
        /// </summary>
        public bool? Fordisplay {
            get { return (bool?) Parameters[nameof(Fordisplay).ToLower()]; }
            set { Parameters[nameof(Fordisplay).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Updates egress firewall rule 
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdateEgressFirewallRule(UpdateEgressFirewallRuleRequest request);
        Task<AsyncJobResponse> UpdateEgressFirewallRuleAsync(UpdateEgressFirewallRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdateEgressFirewallRule(UpdateEgressFirewallRuleRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> UpdateEgressFirewallRuleAsync(UpdateEgressFirewallRuleRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
