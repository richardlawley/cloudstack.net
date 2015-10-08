using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteAffinityGroupRequest : APIRequest
    {
        public DeleteAffinityGroupRequest() : base("deleteAffinityGroup") {}

        /// <summary>
        /// the account of the affinity group. Must be specified with domain ID
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// the domain ID of account owning the affinity group
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// The ID of the affinity group. Mutually exclusive with name parameter
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The name of the affinity group. Mutually exclusive with ID parameter
        /// </summary>
        public string Name { get; set; }

    }
    /// <summary>
    /// Deletes affinity group
    /// </summary>
    /// <summary>
    /// Deletes affinity group
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteAffinityGroup(DeleteAffinityGroupRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteAffinityGroup(DeleteAffinityGroupRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
