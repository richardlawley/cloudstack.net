using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateInstanceGroupRequest : APIRequest
    {
        public CreateInstanceGroupRequest() : base("createInstanceGroup") {}

        /// <summary>
        /// the name of the instance group
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// the account of the instance group. The account parameter must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// the domain ID of account owning the instance group
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// The project of the instance group
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates a vm group
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        InstanceGroupResponse CreateInstanceGroup(CreateInstanceGroupRequest request);
        Task<InstanceGroupResponse> CreateInstanceGroupAsync(CreateInstanceGroupRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public InstanceGroupResponse CreateInstanceGroup(CreateInstanceGroupRequest request) => _proxy.Request<InstanceGroupResponse>(request);
        public Task<InstanceGroupResponse> CreateInstanceGroupAsync(CreateInstanceGroupRequest request) => _proxy.RequestAsync<InstanceGroupResponse>(request);
    }
}
