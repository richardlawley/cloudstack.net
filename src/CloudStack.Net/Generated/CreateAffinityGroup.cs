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
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// Type of the affinity group from the available affinity/anti-affinity group types
        /// </summary>
        public string Type {
            get { return GetParameterValue<string>(nameof(Type).ToLower()); }
            set { SetParameterValue(nameof(Type).ToLower(), value); }
        }

        /// <summary>
        /// an account for the affinity group. Must be used with domainId.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// optional description of the affinity group
        /// </summary>
        public string Description {
            get { return GetParameterValue<string>(nameof(Description).ToLower()); }
            set { SetParameterValue(nameof(Description).ToLower(), value); }
        }

        /// <summary>
        /// domainId of the account owning the affinity group
        /// </summary>
        public Guid DomainId {
            get { return GetParameterValue<Guid>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// create affinity group for project
        /// </summary>
        public Guid ProjectId {
            get { return GetParameterValue<Guid>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
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
