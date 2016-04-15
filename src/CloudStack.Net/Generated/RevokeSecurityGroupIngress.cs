using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RevokeSecurityGroupIngressRequest : APIRequest
    {
        public RevokeSecurityGroupIngressRequest() : base("revokeSecurityGroupIngress") {}

        /// <summary>
        /// The ID of the ingress rule
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a particular ingress rule from this security group
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse RevokeSecurityGroupIngress(RevokeSecurityGroupIngressRequest request);
        Task<AsyncJobResponse> RevokeSecurityGroupIngressAsync(RevokeSecurityGroupIngressRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse RevokeSecurityGroupIngress(RevokeSecurityGroupIngressRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> RevokeSecurityGroupIngressAsync(RevokeSecurityGroupIngressRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
