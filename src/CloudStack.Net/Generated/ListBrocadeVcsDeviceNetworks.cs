using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListBrocadeVcsDeviceNetworksRequest : APIListRequest
    {
        public ListBrocadeVcsDeviceNetworksRequest() : base("listBrocadeVcsDeviceNetworks") {}

        /// <summary>
        /// brocade vcs switch ID
        /// </summary>
        public Guid Vcsdeviceid {
            get { return (Guid) Parameters[nameof(Vcsdeviceid).ToLower()]; }
            set { Parameters[nameof(Vcsdeviceid).ToLower()] = value; }
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
    /// lists network that are using a brocade vcs switch
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<NetworkResponse> ListBrocadeVcsDeviceNetworks(ListBrocadeVcsDeviceNetworksRequest request);
        Task<ListResponse<NetworkResponse>> ListBrocadeVcsDeviceNetworksAsync(ListBrocadeVcsDeviceNetworksRequest request);
        ListResponse<NetworkResponse> ListBrocadeVcsDeviceNetworksAllPages(ListBrocadeVcsDeviceNetworksRequest request);
        Task<ListResponse<NetworkResponse>> ListBrocadeVcsDeviceNetworksAllPagesAsync(ListBrocadeVcsDeviceNetworksRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<NetworkResponse> ListBrocadeVcsDeviceNetworks(ListBrocadeVcsDeviceNetworksRequest request) => _proxy.Request<ListResponse<NetworkResponse>>(request);
        public Task<ListResponse<NetworkResponse>> ListBrocadeVcsDeviceNetworksAsync(ListBrocadeVcsDeviceNetworksRequest request) => _proxy.RequestAsync<ListResponse<NetworkResponse>>(request);
        public ListResponse<NetworkResponse> ListBrocadeVcsDeviceNetworksAllPages(ListBrocadeVcsDeviceNetworksRequest request) => _proxy.RequestAllPages<NetworkResponse>(request);
        public Task<ListResponse<NetworkResponse>> ListBrocadeVcsDeviceNetworksAllPagesAsync(ListBrocadeVcsDeviceNetworksRequest request) => _proxy.RequestAllPagesAsync<NetworkResponse>(request);
    }
}
