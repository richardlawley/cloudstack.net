using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteSecurityGroupRequest : APIRequest
    {
        public DeleteSecurityGroupRequest() : base("deleteSecurityGroup") {}

        /// <summary>
        /// the account of the security group. Must be specified with domain ID
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// the domain ID of account owning the security group
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// The ID of the security group. Mutually exclusive with name parameter
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// The ID of the security group. Mutually exclusive with id parameter
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// the project of the security group
        /// </summary>
        public Guid ProjectId {
            get { return (Guid) Parameters[nameof(ProjectId).ToLower()]; }
            set { Parameters[nameof(ProjectId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Deletes security group
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteSecurityGroup(DeleteSecurityGroupRequest request);
        Task<SuccessResponse> DeleteSecurityGroupAsync(DeleteSecurityGroupRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteSecurityGroup(DeleteSecurityGroupRequest request) => _proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteSecurityGroupAsync(DeleteSecurityGroupRequest request) => _proxy.RequestAsync<SuccessResponse>(request);
    }
}
