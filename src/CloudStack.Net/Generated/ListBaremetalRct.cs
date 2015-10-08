using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListBaremetalRctRequest : APIRequest
    {
        public ListBaremetalRctRequest() : base("listBaremetalRct") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

    }
    /// <summary>
    /// list baremetal rack configuration
    /// </summary>
    /// <summary>
    /// list baremetal rack configuration
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<BaremetalRctResponse> ListBaremetalRct(ListBaremetalRctRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<BaremetalRctResponse> ListBaremetalRct(ListBaremetalRctRequest request) => _proxy.Request<ListResponse<BaremetalRctResponse>>(request);
    }
}
