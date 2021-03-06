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
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId {
            get { return GetParameterValue<string>(nameof(CustomId).ToLower()); }
            set { SetParameterValue(nameof(CustomId).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, whether to the display the rule to the end user or not
        /// </summary>
        public bool? Fordisplay {
            get { return GetParameterValue<bool?>(nameof(Fordisplay).ToLower()); }
            set { SetParameterValue(nameof(Fordisplay).ToLower(), value); }
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
        public AsyncJobResponse UpdateEgressFirewallRule(UpdateEgressFirewallRuleRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> UpdateEgressFirewallRuleAsync(UpdateEgressFirewallRuleRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
