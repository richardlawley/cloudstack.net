using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListBaremetalDhcpRequest : APIListRequest
    {
        public ListBaremetalDhcpRequest() : base("listBaremetalDhcp") {}

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId {
            get { return (Guid) Parameters[nameof(PhysicalNetworkId).ToLower()]; }
            set { Parameters[nameof(PhysicalNetworkId).ToLower()] = value; }
        }

        /// <summary>
        /// Type of DHCP device
        /// </summary>
        public string Dhcpservertype {
            get { return (string) Parameters[nameof(Dhcpservertype).ToLower()]; }
            set { Parameters[nameof(Dhcpservertype).ToLower()] = value; }
        }

        /// <summary>
        /// DHCP server device ID
        /// </summary>
        public long? Id {
            get { return (long?) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
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
    /// list baremetal dhcp servers
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<BaremetalDhcpResponse> ListBaremetalDhcp(ListBaremetalDhcpRequest request);
        Task<ListResponse<BaremetalDhcpResponse>> ListBaremetalDhcpAsync(ListBaremetalDhcpRequest request);
        ListResponse<BaremetalDhcpResponse> ListBaremetalDhcpAllPages(ListBaremetalDhcpRequest request);
        Task<ListResponse<BaremetalDhcpResponse>> ListBaremetalDhcpAllPagesAsync(ListBaremetalDhcpRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<BaremetalDhcpResponse> ListBaremetalDhcp(ListBaremetalDhcpRequest request) => _proxy.Request<ListResponse<BaremetalDhcpResponse>>(request);
        public Task<ListResponse<BaremetalDhcpResponse>> ListBaremetalDhcpAsync(ListBaremetalDhcpRequest request) => _proxy.RequestAsync<ListResponse<BaremetalDhcpResponse>>(request);
        public ListResponse<BaremetalDhcpResponse> ListBaremetalDhcpAllPages(ListBaremetalDhcpRequest request) => _proxy.RequestAllPages<BaremetalDhcpResponse>(request);
        public Task<ListResponse<BaremetalDhcpResponse>> ListBaremetalDhcpAllPagesAsync(ListBaremetalDhcpRequest request) => _proxy.RequestAllPagesAsync<BaremetalDhcpResponse>(request);
    }
}
