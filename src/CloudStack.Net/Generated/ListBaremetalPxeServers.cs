using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListBaremetalPxeServersRequest : APIRequest
    {
        public ListBaremetalPxeServersRequest() : base("listBaremetalPxeServers") {}

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId { get; set; }

        /// <summary>
        /// Pxe server device ID
        /// </summary>
        public long? Id { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

    }
    /// <summary>
    /// list baremetal pxe server
    /// </summary>
    /// <summary>
    /// list baremetal pxe server
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<BaremetalPxeResponse> ListBaremetalPxeServers(ListBaremetalPxeServersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<BaremetalPxeResponse> ListBaremetalPxeServers(ListBaremetalPxeServersRequest request) => _proxy.Request<ListResponse<BaremetalPxeResponse>>(request);
    }
}
