using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateSecurityGroupRequest : APIRequest
    {
        public CreateSecurityGroupRequest() : base("createSecurityGroup") {}

        /// <summary>
        /// name of the security group
        /// </summary>
        public string SecurityGroupName { get; set; }

        /// <summary>
        /// an optional account for the security group. Must be used with domainId.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// the description of the security group
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// an optional domainId for the security group. If the account parameter is used, domainId must also be used.
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// Create security group for project
        /// </summary>
        public Guid ProjectId { get; set; }

    }
    /// <summary>
    /// Creates a security group
    /// </summary>
    /// <summary>
    /// Creates a security group
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SecurityGroupResponse CreateSecurityGroup(CreateSecurityGroupRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SecurityGroupResponse CreateSecurityGroup(CreateSecurityGroupRequest request) => _proxy.Request<SecurityGroupResponse>(request);
    }
}
