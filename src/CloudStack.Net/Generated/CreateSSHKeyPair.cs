using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateSSHKeyPairRequest : APIRequest
    {
        public CreateSSHKeyPairRequest() : base("createSSHKeyPair") {}

        /// <summary>
        /// Name of the keypair
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// an optional account for the ssh key. Must be used with domainId.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// an optional domainId for the ssh key. If the account parameter is used, domainId must also be used.
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// an optional project for the ssh key
        /// </summary>
        public Guid ProjectId { get; set; }

    }
    /// <summary>
    /// Create a new keypair and returns the private key
    /// </summary>
    /// <summary>
    /// Create a new keypair and returns the private key
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        CreateSSHKeyPairResponse CreateSSHKeyPair(CreateSSHKeyPairRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public CreateSSHKeyPairResponse CreateSSHKeyPair(CreateSSHKeyPairRequest request) => _proxy.Request<CreateSSHKeyPairResponse>(request);
    }
}
