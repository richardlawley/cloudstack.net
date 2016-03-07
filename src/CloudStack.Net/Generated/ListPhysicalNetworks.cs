using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListPhysicalNetworksRequest : APIListRequest
    {
        public ListPhysicalNetworksRequest() : base("listPhysicalNetworks") {}

        /// <summary>
        /// list physical network by id
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        /// <summary>
        /// search by name
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// the Zone ID for the physical network
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists physical networks
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<PhysicalNetworkResponse> ListPhysicalNetworks(ListPhysicalNetworksRequest request);
        Task<ListResponse<PhysicalNetworkResponse>> ListPhysicalNetworksAsync(ListPhysicalNetworksRequest request);
        ListResponse<PhysicalNetworkResponse> ListPhysicalNetworksAllPages(ListPhysicalNetworksRequest request);
        Task<ListResponse<PhysicalNetworkResponse>> ListPhysicalNetworksAllPagesAsync(ListPhysicalNetworksRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<PhysicalNetworkResponse> ListPhysicalNetworks(ListPhysicalNetworksRequest request) => _proxy.Request<ListResponse<PhysicalNetworkResponse>>(request);
        public Task<ListResponse<PhysicalNetworkResponse>> ListPhysicalNetworksAsync(ListPhysicalNetworksRequest request) => _proxy.RequestAsync<ListResponse<PhysicalNetworkResponse>>(request);
        public ListResponse<PhysicalNetworkResponse> ListPhysicalNetworksAllPages(ListPhysicalNetworksRequest request) => _proxy.RequestAllPages<PhysicalNetworkResponse>(request);
        public Task<ListResponse<PhysicalNetworkResponse>> ListPhysicalNetworksAllPagesAsync(ListPhysicalNetworksRequest request) => _proxy.RequestAllPagesAsync<PhysicalNetworkResponse>(request);
    }
}
