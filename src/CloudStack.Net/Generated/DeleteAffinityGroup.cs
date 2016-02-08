using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteAffinityGroupRequest : APIRequest
    {
        public DeleteAffinityGroupRequest() : base("deleteAffinityGroup") {}

        /// <summary>
        /// the account of the affinity group. Must be specified with domain ID
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// the domain ID of account owning the affinity group
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// The ID of the affinity group. Mutually exclusive with name parameter
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// The name of the affinity group. Mutually exclusive with ID parameter
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// the project of the affinity group
        /// </summary>
        public Guid ProjectId {
            get { return (Guid) Parameters[nameof(ProjectId).ToLower()]; }
            set { Parameters[nameof(ProjectId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Deletes affinity group
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteAffinityGroup(DeleteAffinityGroupRequest request);
        Task<AsyncJobResponse> DeleteAffinityGroupAsync(DeleteAffinityGroupRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteAffinityGroup(DeleteAffinityGroupRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteAffinityGroupAsync(DeleteAffinityGroupRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
