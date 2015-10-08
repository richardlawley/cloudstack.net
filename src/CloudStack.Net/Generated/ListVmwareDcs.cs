using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListVmwareDcsRequest : APIRequest
    {
        public ListVmwareDcsRequest() : base("listVmwareDcs") {}

        /// <summary>
        /// Id of the CloudStack zone.
        /// </summary>
        public Guid ZoneId { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

    }
    /// <summary>
    /// Retrieves VMware DC(s) associated with a zone.
    /// </summary>
    /// <summary>
    /// Retrieves VMware DC(s) associated with a zone.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<VmwareDatacenterResponse> ListVmwareDcs(ListVmwareDcsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<VmwareDatacenterResponse> ListVmwareDcs(ListVmwareDcsRequest request) => _proxy.Request<ListResponse<VmwareDatacenterResponse>>(request);
    }
}
