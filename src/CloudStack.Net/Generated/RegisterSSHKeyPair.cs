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
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// Public key material of the keypair
        /// </summary>
        public string PublicKey {
            get { return (string) Parameters[nameof(PublicKey).ToLower()]; }
            set { Parameters[nameof(PublicKey).ToLower()] = value; }
        }

        /// <summary>
        /// an optional account for the ssh key. Must be used with domainId.
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// an optional domainId for the ssh key. If the account parameter is used, domainId must also be used.
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// an optional project for the ssh key
        /// </summary>
        public Guid ProjectId {
            get { return (Guid) Parameters[nameof(ProjectId).ToLower()]; }
            set { Parameters[nameof(ProjectId).ToLower()] = value; }
        }

    }
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
