using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteSSHKeyPairRequest : APIRequest
    {
        public DeleteSSHKeyPairRequest() : base("deleteSSHKeyPair") {}

        /// <summary>
        /// Name of the keypair
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the account associated with the keypair. Must be used with the domainId parameter.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// the domain ID associated with the keypair
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// the project associated with keypair
        /// </summary>
        public Guid ProjectId { get; set; }

    }
    /// <summary>
    /// Deletes a keypair by name
    /// </summary>
    /// <summary>
    /// Deletes a keypair by name
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteSSHKeyPair(DeleteSSHKeyPairRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteSSHKeyPair(DeleteSSHKeyPairRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
