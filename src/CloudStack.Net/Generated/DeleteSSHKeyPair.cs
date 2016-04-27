using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteSSHKeyPairRequest : APIRequest
    {
        public DeleteSSHKeyPairRequest() : base("deleteSSHKeyPair") {}

        /// <summary>
        /// Name of the keypair
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// the account associated with the keypair. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// the domain ID associated with the keypair
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// the project associated with keypair
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a keypair by name
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteSSHKeyPair(DeleteSSHKeyPairRequest request);
        Task<SuccessResponse> DeleteSSHKeyPairAsync(DeleteSSHKeyPairRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteSSHKeyPair(DeleteSSHKeyPairRequest request) => _proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteSSHKeyPairAsync(DeleteSSHKeyPairRequest request) => _proxy.RequestAsync<SuccessResponse>(request);
    }
}
