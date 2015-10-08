using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListBaremetalDhcpRequest : APIRequest
    {
        public ListBaremetalDhcpRequest() : base("listBaremetalDhcp") {}

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId { get; set; }

        /// <summary>
        /// Type of DHCP device
        /// </summary>
        public string DeviceType { get; set; }

        /// <summary>
        /// DHCP server device ID
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
    /// list baremetal dhcp servers
    /// </summary>
    /// <summary>
    /// list baremetal dhcp servers
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<BaremetalDhcpResponse> ListBaremetalDhcp(ListBaremetalDhcpRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<BaremetalDhcpResponse> ListBaremetalDhcp(ListBaremetalDhcpRequest request) => _proxy.Request<ListResponse<BaremetalDhcpResponse>>(request);
    }
}
