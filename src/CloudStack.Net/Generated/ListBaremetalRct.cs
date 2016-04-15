using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListBaremetalRctRequest : APIListRequest
    {
        public ListBaremetalRctRequest() : base("listBaremetalRct") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

    }
    /// <summary>
    /// list baremetal rack configuration
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<BaremetalRctResponse> ListBaremetalRct(ListBaremetalRctRequest request);
        Task<ListResponse<BaremetalRctResponse>> ListBaremetalRctAsync(ListBaremetalRctRequest request);
        ListResponse<BaremetalRctResponse> ListBaremetalRctAllPages(ListBaremetalRctRequest request);
        Task<ListResponse<BaremetalRctResponse>> ListBaremetalRctAllPagesAsync(ListBaremetalRctRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<BaremetalRctResponse> ListBaremetalRct(ListBaremetalRctRequest request) => _proxy.Request<ListResponse<BaremetalRctResponse>>(request);
        public Task<ListResponse<BaremetalRctResponse>> ListBaremetalRctAsync(ListBaremetalRctRequest request) => _proxy.RequestAsync<ListResponse<BaremetalRctResponse>>(request);
        public ListResponse<BaremetalRctResponse> ListBaremetalRctAllPages(ListBaremetalRctRequest request) => _proxy.RequestAllPages<BaremetalRctResponse>(request);
        public Task<ListResponse<BaremetalRctResponse>> ListBaremetalRctAllPagesAsync(ListBaremetalRctRequest request) => _proxy.RequestAllPagesAsync<BaremetalRctResponse>(request);
    }
}
