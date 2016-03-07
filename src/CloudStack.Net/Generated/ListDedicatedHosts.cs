using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListDedicatedHostsRequest : APIListRequest
    {
        public ListDedicatedHostsRequest() : base("listDedicatedHosts") {}

        /// <summary>
        /// the name of the account associated with the host. Must be used with domainId.
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// list dedicated hosts by affinity group
        /// </summary>
        public Guid AffinityGroupId {
            get { return (Guid) Parameters[nameof(AffinityGroupId).ToLower()]; }
            set { Parameters[nameof(AffinityGroupId).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the domain associated with the host
        /// </summary>
        public Guid DomainId {
            get { return (Guid) Parameters[nameof(DomainId).ToLower()]; }
            set { Parameters[nameof(DomainId).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the host
        /// </summary>
        public Guid HostId {
            get { return (Guid) Parameters[nameof(HostId).ToLower()]; }
            set { Parameters[nameof(HostId).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists dedicated hosts.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<DedicateHostResponse> ListDedicatedHosts(ListDedicatedHostsRequest request);
        Task<ListResponse<DedicateHostResponse>> ListDedicatedHostsAsync(ListDedicatedHostsRequest request);
        ListResponse<DedicateHostResponse> ListDedicatedHostsAllPages(ListDedicatedHostsRequest request);
        Task<ListResponse<DedicateHostResponse>> ListDedicatedHostsAllPagesAsync(ListDedicatedHostsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<DedicateHostResponse> ListDedicatedHosts(ListDedicatedHostsRequest request) => _proxy.Request<ListResponse<DedicateHostResponse>>(request);
        public Task<ListResponse<DedicateHostResponse>> ListDedicatedHostsAsync(ListDedicatedHostsRequest request) => _proxy.RequestAsync<ListResponse<DedicateHostResponse>>(request);
        public ListResponse<DedicateHostResponse> ListDedicatedHostsAllPages(ListDedicatedHostsRequest request) => _proxy.RequestAllPages<DedicateHostResponse>(request);
        public Task<ListResponse<DedicateHostResponse>> ListDedicatedHostsAllPagesAsync(ListDedicatedHostsRequest request) => _proxy.RequestAllPagesAsync<DedicateHostResponse>(request);
    }
}
