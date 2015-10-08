using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateInstanceGroupRequest : APIRequest
    {
        public CreateInstanceGroupRequest() : base("createInstanceGroup") {}

        /// <summary>
        /// the name of the instance group
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// the account of the instance group. The account parameter must be used with the domainId parameter.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// the domain ID of account owning the instance group
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// The project of the instance group
        /// </summary>
        public Guid ProjectId { get; set; }

    }
    /// <summary>
    /// Creates a vm group
    /// </summary>
    /// <summary>
    /// Creates a vm group
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        InstanceGroupResponse CreateInstanceGroup(CreateInstanceGroupRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public InstanceGroupResponse CreateInstanceGroup(CreateInstanceGroupRequest request) => _proxy.Request<InstanceGroupResponse>(request);
    }
}
