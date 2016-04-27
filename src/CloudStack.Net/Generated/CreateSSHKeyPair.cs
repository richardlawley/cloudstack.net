using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateSSHKeyPairRequest : APIRequest
    {
        public CreateSSHKeyPairRequest() : base("createSSHKeyPair") {}

        /// <summary>
        /// Name of the keypair
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
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
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// an optional project for the ssh key
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Create a new keypair and returns the private key
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        CreateSSHKeyPairResponse CreateSSHKeyPair(CreateSSHKeyPairRequest request);
        Task<CreateSSHKeyPairResponse> CreateSSHKeyPairAsync(CreateSSHKeyPairRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public CreateSSHKeyPairResponse CreateSSHKeyPair(CreateSSHKeyPairRequest request) => _proxy.Request<CreateSSHKeyPairResponse>(request);
        public Task<CreateSSHKeyPairResponse> CreateSSHKeyPairAsync(CreateSSHKeyPairRequest request) => _proxy.RequestAsync<CreateSSHKeyPairResponse>(request);
    }
}
