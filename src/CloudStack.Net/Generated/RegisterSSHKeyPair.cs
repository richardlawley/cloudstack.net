using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// Public key material of the keypair
        /// </summary>
        public string PublicKey {
            get { return GetParameterValue<string>(nameof(PublicKey).ToLower()); }
            set { SetParameterValue(nameof(PublicKey).ToLower(), value); }
        }

        /// <summary>
        /// an optional account for the ssh key. Must be used with domainId.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// an optional domainId for the ssh key. If the account parameter is used, domainId must also be used.
        /// </summary>
        public Guid DomainId {
            get { return GetParameterValue<Guid>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// an optional project for the ssh key
        /// </summary>
        public Guid ProjectId {
            get { return GetParameterValue<Guid>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Register a public key in a keypair under a certain name
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SSHKeyPairResponse RegisterSSHKeyPair(RegisterSSHKeyPairRequest request);
        Task<SSHKeyPairResponse> RegisterSSHKeyPairAsync(RegisterSSHKeyPairRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SSHKeyPairResponse RegisterSSHKeyPair(RegisterSSHKeyPairRequest request) => _proxy.Request<SSHKeyPairResponse>(request);
        public Task<SSHKeyPairResponse> RegisterSSHKeyPairAsync(RegisterSSHKeyPairRequest request) => _proxy.RequestAsync<SSHKeyPairResponse>(request);
    }
}
