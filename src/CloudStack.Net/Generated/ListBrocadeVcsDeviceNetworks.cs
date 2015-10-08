using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListBrocadeVcsDeviceNetworksRequest : APIRequest
    {
        public ListBrocadeVcsDeviceNetworksRequest() : base("listBrocadeVcsDeviceNetworks") {}

        /// <summary>
        /// brocade vcs switch ID
        /// </summary>
        public Guid BrocadeVcsDeviceId { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

    }
    /// <summary>
    /// lists network that are using a brocade vcs switch
    /// </summary>
    /// <summary>
    /// lists network that are using a brocade vcs switch
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<NetworkResponse> ListBrocadeVcsDeviceNetworks(ListBrocadeVcsDeviceNetworksRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<NetworkResponse> ListBrocadeVcsDeviceNetworks(ListBrocadeVcsDeviceNetworksRequest request) => _proxy.Request<ListResponse<NetworkResponse>>(request);
    }
}
