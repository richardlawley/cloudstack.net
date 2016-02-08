using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateSecurityGroupRequest : APIRequest
    {
        public CreateSecurityGroupRequest() : base("createSecurityGroup") {}

        /// <summary>
        /// name of the security group
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// an optional account for the security group. Must be used with domainId.
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// the description of the security group
        /// </summary>
        public string Description {
            get { return (string) Parameters[nameof(Description).ToLower()]; }
            set { Parameters[nameof(Description).ToLower()] = value; }
        }

        /// <summary>
        /// an optional domainId for the security group. If the account parameter is used, domainId must also be used.
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// Create security group for project
        /// </summary>
        public Guid ProjectId {
            get { return (Guid) Parameters[nameof(ProjectId).ToLower()]; }
            set { Parameters[nameof(ProjectId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Creates a security group
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SecurityGroupResponse CreateSecurityGroup(CreateSecurityGroupRequest request);
        Task<SecurityGroupResponse> CreateSecurityGroupAsync(CreateSecurityGroupRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SecurityGroupResponse CreateSecurityGroup(CreateSecurityGroupRequest request) => _proxy.Request<SecurityGroupResponse>(request);
        public Task<SecurityGroupResponse> CreateSecurityGroupAsync(CreateSecurityGroupRequest request) => _proxy.RequestAsync<SecurityGroupResponse>(request);
    }
}
