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
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// an optional account for the security group. Must be used with domainId.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// the description of the security group
        /// </summary>
        public string Description {
            get { return GetParameterValue<string>(nameof(Description).ToLower()); }
            set { SetParameterValue(nameof(Description).ToLower(), value); }
        }

        /// <summary>
        /// an optional domainId for the security group. If the account parameter is used, domainId must also be used.
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// Create security group for project
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
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
