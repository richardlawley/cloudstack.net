using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateAffinityGroupRequest : APIRequest
    {
        public CreateAffinityGroupRequest() : base("createAffinityGroup") {}

        /// <summary>
        /// name of the affinity group
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// Type of the affinity group from the available affinity/anti-affinity group types
        /// </summary>
        public string Type {
            get { return (string) Parameters[nameof(Type).ToLower()]; }
            set { Parameters[nameof(Type).ToLower()] = value; }
        }

        /// <summary>
        /// an account for the affinity group. Must be used with domainId.
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// optional description of the affinity group
        /// </summary>
        public string Description {
            get { return (string) Parameters[nameof(Description).ToLower()]; }
            set { Parameters[nameof(Description).ToLower()] = value; }
        }

        /// <summary>
        /// domainId of the account owning the affinity group
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// create affinity group for project
        /// </summary>
        public Guid ProjectId {
            get { return (Guid) Parameters[nameof(ProjectId).ToLower()]; }
            set { Parameters[nameof(ProjectId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Creates an affinity/anti-affinity group
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateAffinityGroup(CreateAffinityGroupRequest request);
        Task<AsyncJobResponse> CreateAffinityGroupAsync(CreateAffinityGroupRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateAffinityGroup(CreateAffinityGroupRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateAffinityGroupAsync(CreateAffinityGroupRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
