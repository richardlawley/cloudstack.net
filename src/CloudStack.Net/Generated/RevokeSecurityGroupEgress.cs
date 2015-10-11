using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Deletes a particular egress rule from this security group
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse RevokeSecurityGroupEgress(RevokeSecurityGroupEgressRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse RevokeSecurityGroupEgress(RevokeSecurityGroupEgressRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
