using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DedicatePublicIpRangeRequest : APIRequest
    {
        public DedicatePublicIpRangeRequest() : base("dedicatePublicIpRange") {}

        /// <summary>
        /// the id of the VLAN IP range
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// domain ID of the account owning a VLAN
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// account who will own the VLAN
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// project who will own the VLAN
        /// </summary>
        public Guid ProjectId {
            get { return (Guid) Parameters[nameof(ProjectId).ToLower()]; }
            set { Parameters[nameof(ProjectId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Dedicates a Public IP range to an account
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        VlanIpRangeResponse DedicatePublicIpRange(DedicatePublicIpRangeRequest request);
        Task<VlanIpRangeResponse> DedicatePublicIpRangeAsync(DedicatePublicIpRangeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public VlanIpRangeResponse DedicatePublicIpRange(DedicatePublicIpRangeRequest request) => _proxy.Request<VlanIpRangeResponse>(request);
        public Task<VlanIpRangeResponse> DedicatePublicIpRangeAsync(DedicatePublicIpRangeRequest request) => _proxy.RequestAsync<VlanIpRangeResponse>(request);
    }
}
