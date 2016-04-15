using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AuthorizeSecurityGroupIngressRequest : APIRequest
    {
        public AuthorizeSecurityGroupIngressRequest() : base("authorizeSecurityGroupIngress") {}

        /// <summary>
        /// an optional account for the security group. Must be used with domainId.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// the cidr list associated
        /// </summary>
        public IList<string> CidrList {
            get { return GetList<string>(nameof(CidrList).ToLower()); }
            set { SetParameterValue(nameof(CidrList).ToLower(), value); }
        }

        /// <summary>
        /// an optional domainId for the security group. If the account parameter is used, domainId must also be used.
        /// </summary>
        public Guid DomainId {
            get { return GetParameterValue<Guid>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// end port for this ingress rule
        /// </summary>
        public int? EndPort {
            get { return GetParameterValue<int?>(nameof(EndPort).ToLower()); }
            set { SetParameterValue(nameof(EndPort).ToLower(), value); }
        }

        /// <summary>
        /// error code for this icmp message
        /// </summary>
        public int? IcmpCode {
            get { return GetParameterValue<int?>(nameof(IcmpCode).ToLower()); }
            set { SetParameterValue(nameof(IcmpCode).ToLower(), value); }
        }

        /// <summary>
        /// type of the icmp message being sent
        /// </summary>
        public int? IcmpType {
            get { return GetParameterValue<int?>(nameof(IcmpType).ToLower()); }
            set { SetParameterValue(nameof(IcmpType).ToLower(), value); }
        }

        /// <summary>
        /// an optional project of the security group
        /// </summary>
        public Guid ProjectId {
            get { return GetParameterValue<Guid>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// TCP is default. UDP is the other supported protocol
        /// </summary>
        public string Protocol {
            get { return GetParameterValue<string>(nameof(Protocol).ToLower()); }
            set { SetParameterValue(nameof(Protocol).ToLower(), value); }
        }

        /// <summary>
        /// The ID of the security group. Mutually exclusive with securityGroupName parameter
        /// </summary>
        public Guid SecurityGroupId {
            get { return GetParameterValue<Guid>(nameof(SecurityGroupId).ToLower()); }
            set { SetParameterValue(nameof(SecurityGroupId).ToLower(), value); }
        }

        /// <summary>
        /// The name of the security group. Mutually exclusive with securityGroupId parameter
        /// </summary>
        public string SecurityGroupName {
            get { return GetParameterValue<string>(nameof(SecurityGroupName).ToLower()); }
            set { SetParameterValue(nameof(SecurityGroupName).ToLower(), value); }
        }

        /// <summary>
        /// start port for this ingress rule
        /// </summary>
        public int? StartPort {
            get { return GetParameterValue<int?>(nameof(StartPort).ToLower()); }
            set { SetParameterValue(nameof(StartPort).ToLower(), value); }
        }

        /// <summary>
        /// user to security group mapping
        /// </summary>
        public IList<IDictionary<string, object>> UserSecurityGroupList {
            get { return GetList<IDictionary<string, object>>(nameof(UserSecurityGroupList).ToLower()); }
            set { SetParameterValue(nameof(UserSecurityGroupList).ToLower(), value); }
        }

    }
    /// <summary>
    /// Authorizes a particular ingress rule for this security group
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AuthorizeSecurityGroupIngress(AuthorizeSecurityGroupIngressRequest request);
        Task<AsyncJobResponse> AuthorizeSecurityGroupIngressAsync(AuthorizeSecurityGroupIngressRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AuthorizeSecurityGroupIngress(AuthorizeSecurityGroupIngressRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> AuthorizeSecurityGroupIngressAsync(AuthorizeSecurityGroupIngressRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
