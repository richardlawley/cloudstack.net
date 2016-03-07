using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListVmwareDcsRequest : APIListRequest
    {
        public ListVmwareDcsRequest() : base("listVmwareDcs") {}

        /// <summary>
        /// Id of the CloudStack zone.
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
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
    /// Retrieves VMware DC(s) associated with a zone.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<VmwareDatacenterResponse> ListVmwareDcs(ListVmwareDcsRequest request);
        Task<ListResponse<VmwareDatacenterResponse>> ListVmwareDcsAsync(ListVmwareDcsRequest request);
        ListResponse<VmwareDatacenterResponse> ListVmwareDcsAllPages(ListVmwareDcsRequest request);
        Task<ListResponse<VmwareDatacenterResponse>> ListVmwareDcsAllPagesAsync(ListVmwareDcsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<VmwareDatacenterResponse> ListVmwareDcs(ListVmwareDcsRequest request) => _proxy.Request<ListResponse<VmwareDatacenterResponse>>(request);
        public Task<ListResponse<VmwareDatacenterResponse>> ListVmwareDcsAsync(ListVmwareDcsRequest request) => _proxy.RequestAsync<ListResponse<VmwareDatacenterResponse>>(request);
        public ListResponse<VmwareDatacenterResponse> ListVmwareDcsAllPages(ListVmwareDcsRequest request) => _proxy.RequestAllPages<VmwareDatacenterResponse>(request);
        public Task<ListResponse<VmwareDatacenterResponse>> ListVmwareDcsAllPagesAsync(ListVmwareDcsRequest request) => _proxy.RequestAllPagesAsync<VmwareDatacenterResponse>(request);
    }
}
