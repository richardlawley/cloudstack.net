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
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Deletes a particular ingress rule from this security group
    /// </summary>
    /// <summary>
    /// Deletes a particular ingress rule from this security group
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse RevokeSecurityGroupIngress(RevokeSecurityGroupIngressRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse RevokeSecurityGroupIngress(RevokeSecurityGroupIngressRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
