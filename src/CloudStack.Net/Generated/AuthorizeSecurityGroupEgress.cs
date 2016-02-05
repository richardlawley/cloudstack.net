using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AuthorizeSecurityGroupEgressRequest : APIRequest
    {
        public AuthorizeSecurityGroupEgressRequest() : base("authorizeSecurityGroupEgress") {}

        /// <summary>
        /// an optional account for the security group. Must be used with domainId.
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// the cidr list associated
        /// </summary>
        public IList<string> CidrList {
            get { return GetList<string>(nameof(CidrList).ToLower()); }
            set { Parameters[nameof(CidrList).ToLower()] = value; }
        }

        /// <summary>
        /// an optional domainId for the security group. If the account parameter is used, domainId must also be used.
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// end port for this egress rule
        /// </summary>
        public int? EndPort {
            get { return (int?) Parameters[nameof(EndPort).ToLower()]; }
            set { Parameters[nameof(EndPort).ToLower()] = value; }
        }

        /// <summary>
        /// error code for this icmp message
        /// </summary>
        public int? IcmpCode {
            get { return (int?) Parameters[nameof(IcmpCode).ToLower()]; }
            set { Parameters[nameof(IcmpCode).ToLower()] = value; }
        }

        /// <summary>
        /// type of the icmp message being sent
        /// </summary>
        public int? IcmpType {
            get { return (int?) Parameters[nameof(IcmpType).ToLower()]; }
            set { Parameters[nameof(IcmpType).ToLower()] = value; }
        }

        /// <summary>
        /// an optional project of the security group
        /// </summary>
        public Guid ProjectId {
            get { return (Guid) Parameters[nameof(ProjectId).ToLower()]; }
            set { Parameters[nameof(ProjectId).ToLower()] = value; }
        }

        /// <summary>
        /// TCP is default. UDP is the other supported protocol
        /// </summary>
        public string Protocol {
            get { return (string) Parameters[nameof(Protocol).ToLower()]; }
            set { Parameters[nameof(Protocol).ToLower()] = value; }
        }

        /// <summary>
        /// The ID of the security group. Mutually exclusive with securityGroupName parameter
        /// </summary>
        public Guid SecurityGroupId {
            get { return (Guid) Parameters[nameof(SecurityGroupId).ToLower()]; }
            set { Parameters[nameof(SecurityGroupId).ToLower()] = value; }
        }

        /// <summary>
        /// The name of the security group. Mutually exclusive with securityGroupId parameter
        /// </summary>
        public string SecurityGroupName {
            get { return (string) Parameters[nameof(SecurityGroupName).ToLower()]; }
            set { Parameters[nameof(SecurityGroupName).ToLower()] = value; }
        }

        /// <summary>
        /// start port for this egress rule
        /// </summary>
        public int? StartPort {
            get { return (int?) Parameters[nameof(StartPort).ToLower()]; }
            set { Parameters[nameof(StartPort).ToLower()] = value; }
        }

        /// <summary>
        /// user to security group mapping
        /// </summary>
        public IList<IDictionary<string, object>> UserSecurityGroupList {
            get { return GetList<IDictionary<string, object>>(nameof(UserSecurityGroupList).ToLower()); }
            set { Parameters[nameof(UserSecurityGroupList).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Authorizes a particular egress rule for this security group
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AuthorizeSecurityGroupEgress(AuthorizeSecurityGroupEgressRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AuthorizeSecurityGroupEgress(AuthorizeSecurityGroupEgressRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
