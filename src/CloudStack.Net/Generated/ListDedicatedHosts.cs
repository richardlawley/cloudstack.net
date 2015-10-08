using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListDedicatedHostsRequest : APIRequest
    {
        public ListDedicatedHostsRequest() : base("listDedicatedHosts") {}

        /// <summary>
        /// the name of the account associated with the host. Must be used with domainId.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// list dedicated hosts by affinity group
        /// </summary>
        public Guid AffinityGroupId { get; set; }

        /// <summary>
        /// the ID of the domain associated with the host
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// the ID of the host
        /// </summary>
        public Guid HostId { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

    }
    /// <summary>
    /// Lists dedicated hosts.
    /// </summary>
    /// <summary>
    /// Lists dedicated hosts.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<DedicateHostResponse> ListDedicatedHosts(ListDedicatedHostsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<DedicateHostResponse> ListDedicatedHosts(ListDedicatedHostsRequest request) => _proxy.Request<ListResponse<DedicateHostResponse>>(request);
    }
}
