using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListPhysicalNetworksRequest : APIRequest
    {
        public ListPhysicalNetworksRequest() : base("listPhysicalNetworks") {}

        /// <summary>
        /// list physical network by id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// search by name
        /// </summary>
        public string NetworkName { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// the Zone ID for the physical network
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// Lists physical networks
    /// </summary>
    /// <summary>
    /// Lists physical networks
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<PhysicalNetworkResponse> ListPhysicalNetworks(ListPhysicalNetworksRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<PhysicalNetworkResponse> ListPhysicalNetworks(ListPhysicalNetworksRequest request) => _proxy.Request<ListResponse<PhysicalNetworkResponse>>(request);
    }
}
