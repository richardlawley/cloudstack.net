using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateAffinityGroupRequest : APIRequest
    {
        public CreateAffinityGroupRequest() : base("createAffinityGroup") {}

        /// <summary>
        /// name of the affinity group
        /// </summary>
        public string AffinityGroupName { get; set; }

        /// <summary>
        /// Type of the affinity group from the available affinity/anti-affinity group types
        /// </summary>
        public string AffinityGroupType { get; set; }

        /// <summary>
        /// an account for the affinity group. Must be used with domainId.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// optional description of the affinity group
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// domainId of the account owning the affinity group
        /// </summary>
        public Guid DomainId { get; set; }

    }
    /// <summary>
    /// Creates an affinity/anti-affinity group
    /// </summary>
    /// <summary>
    /// Creates an affinity/anti-affinity group
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AffinityGroupResponse CreateAffinityGroup(CreateAffinityGroupRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AffinityGroupResponse CreateAffinityGroup(CreateAffinityGroupRequest request) => _proxy.Request<AffinityGroupResponse>(request);
    }
}
