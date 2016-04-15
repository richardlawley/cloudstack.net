using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteEgressFirewallRuleRequest : APIRequest
    {
        public DeleteEgressFirewallRuleRequest() : base("deleteEgressFirewallRule") {}

        /// <summary>
        /// the ID of the firewall rule
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes an egress firewall rule
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteEgressFirewallRule(DeleteEgressFirewallRuleRequest request);
        Task<AsyncJobResponse> DeleteEgressFirewallRuleAsync(DeleteEgressFirewallRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteEgressFirewallRule(DeleteEgressFirewallRuleRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteEgressFirewallRuleAsync(DeleteEgressFirewallRuleRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
