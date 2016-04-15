using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteFirewallRuleRequest : APIRequest
    {
        public DeleteFirewallRuleRequest() : base("deleteFirewallRule") {}

        /// <summary>
        /// the ID of the firewall rule
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a firewall rule
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteFirewallRule(DeleteFirewallRuleRequest request);
        Task<AsyncJobResponse> DeleteFirewallRuleAsync(DeleteFirewallRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteFirewallRule(DeleteFirewallRuleRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteFirewallRuleAsync(DeleteFirewallRuleRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
