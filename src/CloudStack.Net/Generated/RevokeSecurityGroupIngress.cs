using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Deletes a particular ingress rule from this security group
    /// </summary>
    /// <summary>
    /// Deletes a particular ingress rule from this security group
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse RevokeSecurityGroupIngress(RevokeSecurityGroupIngressRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse RevokeSecurityGroupIngress(RevokeSecurityGroupIngressRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
