using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListSSHKeyPairsRequest : APIListRequest
    {
        public ListSSHKeyPairsRequest() : base("listSSHKeyPairs") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// A public key fingerprint to look for
        /// </summary>
        public string Fingerprint {
            get { return GetParameterValue<string>(nameof(Fingerprint).ToLower()); }
            set { SetParameterValue(nameof(Fingerprint).ToLower(), value); }
        }

        /// <summary>
        /// defaults to false, but if true, lists all resources from the parent specified by the domainId till leaves.
        /// </summary>
        public bool? Isrecursive {
            get { return GetParameterValue<bool?>(nameof(Isrecursive).ToLower()); }
            set { SetParameterValue(nameof(Isrecursive).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// If set to false, list only resources belonging to the command's caller; if set to true - list resources that the caller is authorized to see. Default value is false
        /// </summary>
        public bool? ListAll {
            get { return GetParameterValue<bool?>(nameof(ListAll).ToLower()); }
            set { SetParameterValue(nameof(ListAll).ToLower(), value); }
        }

        /// <summary>
        /// A key pair name to look for
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// list objects by project
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

    }
    /// <summary>
    /// List registered keypairs
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<SSHKeyPairResponse> ListSSHKeyPairs(ListSSHKeyPairsRequest request);
        Task<ListResponse<SSHKeyPairResponse>> ListSSHKeyPairsAsync(ListSSHKeyPairsRequest request);
        ListResponse<SSHKeyPairResponse> ListSSHKeyPairsAllPages(ListSSHKeyPairsRequest request);
        Task<ListResponse<SSHKeyPairResponse>> ListSSHKeyPairsAllPagesAsync(ListSSHKeyPairsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<SSHKeyPairResponse> ListSSHKeyPairs(ListSSHKeyPairsRequest request) => Proxy.Request<ListResponse<SSHKeyPairResponse>>(request);
        public Task<ListResponse<SSHKeyPairResponse>> ListSSHKeyPairsAsync(ListSSHKeyPairsRequest request) => Proxy.RequestAsync<ListResponse<SSHKeyPairResponse>>(request);
        public ListResponse<SSHKeyPairResponse> ListSSHKeyPairsAllPages(ListSSHKeyPairsRequest request) => Proxy.RequestAllPages<SSHKeyPairResponse>(request);
        public Task<ListResponse<SSHKeyPairResponse>> ListSSHKeyPairsAllPagesAsync(ListSSHKeyPairsRequest request) => Proxy.RequestAllPagesAsync<SSHKeyPairResponse>(request);
    }
}
