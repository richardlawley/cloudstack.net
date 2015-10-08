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
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Deletes a particular egress rule from this security group
    /// </summary>
    /// <summary>
    /// Deletes a particular egress rule from this security group
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse RevokeSecurityGroupEgress(RevokeSecurityGroupEgressRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse RevokeSecurityGroupEgress(RevokeSecurityGroupEgressRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
