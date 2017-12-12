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
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// list dedicated hosts by affinity group
        /// </summary>
        public Guid? AffinityGroupId {
            get { return GetParameterValue<Guid?>(nameof(AffinityGroupId).ToLower()); }
            set { SetParameterValue(nameof(AffinityGroupId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the domain associated with the host
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the host
        /// </summary>
        public Guid? HostId {
            get { return GetParameterValue<Guid?>(nameof(HostId).ToLower()); }
            set { SetParameterValue(nameof(HostId).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
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
        public ListResponse<DedicateHostResponse> ListDedicatedHosts(ListDedicatedHostsRequest request) => Proxy.Request<ListResponse<DedicateHostResponse>>(request);
        public Task<ListResponse<DedicateHostResponse>> ListDedicatedHostsAsync(ListDedicatedHostsRequest request) => Proxy.RequestAsync<ListResponse<DedicateHostResponse>>(request);
        public ListResponse<DedicateHostResponse> ListDedicatedHostsAllPages(ListDedicatedHostsRequest request) => Proxy.RequestAllPages<DedicateHostResponse>(request);
        public Task<ListResponse<DedicateHostResponse>> ListDedicatedHostsAllPagesAsync(ListDedicatedHostsRequest request) => Proxy.RequestAllPagesAsync<DedicateHostResponse>(request);
    }
}
