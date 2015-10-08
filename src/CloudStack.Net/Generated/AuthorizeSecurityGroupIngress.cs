using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AuthorizeSecurityGroupIngressRequest : APIRequest
    {
        public AuthorizeSecurityGroupIngressRequest() : base("authorizeSecurityGroupIngress") {}

        /// <summary>
        /// an optional account for the security group. Must be used with domainId.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// the cidr list associated
        /// </summary>
        public IList<string> CidrList { get; set; }

        /// <summary>
        /// an optional domainId for the security group. If the account parameter is used, domainId must also be used.
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// end port for this ingress rule
        /// </summary>
        public int? EndPort { get; set; }

        /// <summary>
        /// error code for this icmp message
        /// </summary>
        public int? IcmpCode { get; set; }

        /// <summary>
        /// type of the icmp message being sent
        /// </summary>
        public int? IcmpType { get; set; }

        /// <summary>
        /// an optional project of the security group
        /// </summary>
        public Guid ProjectId { get; set; }

        /// <summary>
        /// TCP is default. UDP is the other supported protocol
        /// </summary>
        public string Protocol { get; set; }

        /// <summary>
        /// The ID of the security group. Mutually exclusive with securityGroupName parameter
        /// </summary>
        public Guid SecurityGroupId { get; set; }

        /// <summary>
        /// The name of the security group. Mutually exclusive with securityGroupId parameter
        /// </summary>
        public string SecurityGroupName { get; set; }

        /// <summary>
        /// start port for this ingress rule
        /// </summary>
        public int? StartPort { get; set; }

        /// <summary>
        /// user to security group mapping
        /// </summary>
        public IDictionary<string, string> UserSecurityGroupList { get; set; }

    }
    /// <summary>
    /// Authorizes a particular ingress rule for this security group
    /// </summary>
    /// <summary>
    /// Authorizes a particular ingress rule for this security group
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SecurityGroupRuleResponse AuthorizeSecurityGroupIngress(AuthorizeSecurityGroupIngressRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SecurityGroupRuleResponse AuthorizeSecurityGroupIngress(AuthorizeSecurityGroupIngressRequest request) => _proxy.Request<SecurityGroupRuleResponse>(request);
    }
}
