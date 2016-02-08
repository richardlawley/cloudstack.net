using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListVmwareDcsRequest : APIRequest
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

        public int? Page {
            get { return (int?) Parameters[nameof(Page).ToLower()]; }
            set { Parameters[nameof(Page).ToLower()] = value; }
        }

        public int? PageSize {
            get { return (int?) Parameters[nameof(PageSize).ToLower()]; }
            set { Parameters[nameof(PageSize).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Retrieves VMware DC(s) associated with a zone.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<VmwareDatacenterResponse> ListVmwareDcs(ListVmwareDcsRequest request);
        Task<ListResponse<VmwareDatacenterResponse>> ListVmwareDcsAsync(ListVmwareDcsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<VmwareDatacenterResponse> ListVmwareDcs(ListVmwareDcsRequest request) => _proxy.Request<ListResponse<VmwareDatacenterResponse>>(request);
        public Task<ListResponse<VmwareDatacenterResponse>> ListVmwareDcsAsync(ListVmwareDcsRequest request) => _proxy.RequestAsync<ListResponse<VmwareDatacenterResponse>>(request);
    }
}
