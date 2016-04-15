using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RevokeSecurityGroupEgressRequest : APIRequest
    {
        public RevokeSecurityGroupEgressRequest() : base("revokeSecurityGroupEgress") {}

        /// <summary>
        /// The ID of the egress rule
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a particular egress rule from this security group
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse RevokeSecurityGroupEgress(RevokeSecurityGroupEgressRequest request);
        Task<AsyncJobResponse> RevokeSecurityGroupEgressAsync(RevokeSecurityGroupEgressRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse RevokeSecurityGroupEgress(RevokeSecurityGroupEgressRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> RevokeSecurityGroupEgressAsync(RevokeSecurityGroupEgressRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
