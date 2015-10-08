using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteSecurityGroupRequest : APIRequest
    {
        public DeleteSecurityGroupRequest() : base("deleteSecurityGroup") {}

        /// <summary>
        /// the account of the security group. Must be specified with domain ID
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// the domain ID of account owning the security group
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// The ID of the security group. Mutually exclusive with name parameter
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The ID of the security group. Mutually exclusive with id parameter
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the project of the security group
        /// </summary>
        public Guid ProjectId { get; set; }

    }
    /// <summary>
    /// Deletes security group
    /// </summary>
    /// <summary>
    /// Deletes security group
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteSecurityGroup(DeleteSecurityGroupRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteSecurityGroup(DeleteSecurityGroupRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
