using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListNiciraNvpDeviceNetworksRequest : APIRequest
    {
        public ListNiciraNvpDeviceNetworksRequest() : base("listNiciraNvpDeviceNetworks") {}

        /// <summary>
        /// nicira nvp device ID
        /// </summary>
        public Guid NiciraNvpDeviceId { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

    }
    /// <summary>
    /// lists network that are using a nicira nvp device
    /// </summary>
    /// <summary>
    /// lists network that are using a nicira nvp device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<NetworkResponse> ListNiciraNvpDeviceNetworks(ListNiciraNvpDeviceNetworksRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<NetworkResponse> ListNiciraNvpDeviceNetworks(ListNiciraNvpDeviceNetworksRequest request) => _proxy.Request<ListResponse<NetworkResponse>>(request);
    }
}
