using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes an IP forwarding rule
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteIpForwardingRule(DeleteIpForwardingRuleRequest request);
        Task<AsyncJobResponse> DeleteIpForwardingRuleAsync(DeleteIpForwardingRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteIpForwardingRule(DeleteIpForwardingRuleRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteIpForwardingRuleAsync(DeleteIpForwardingRuleRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
