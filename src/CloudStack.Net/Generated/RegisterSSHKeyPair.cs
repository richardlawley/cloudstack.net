using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RegisterSSHKeyPairRequest : APIRequest
    {
        public RegisterSSHKeyPairRequest() : base("registerSSHKeyPair") {}

        /// <summary>
        /// Name of the keypair
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Public key material of the keypair
        /// </summary>
        public string PublicKey { get; set; }

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
    /// Register a public key in a keypair under a certain name
    /// </summary>
    /// <summary>
    /// Register a public key in a keypair under a certain name
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SSHKeyPairResponse RegisterSSHKeyPair(RegisterSSHKeyPairRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SSHKeyPairResponse RegisterSSHKeyPair(RegisterSSHKeyPairRequest request) => _proxy.Request<SSHKeyPairResponse>(request);
    }
}
