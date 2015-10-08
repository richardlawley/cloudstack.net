using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListUcsBladesRequest : APIRequest
    {
        public ListUcsBladesRequest() : base("listUcsBlades") {}

        /// <summary>
        /// ucs manager id
        /// </summary>
        public Guid UcsManagerId { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

    }
    /// <summary>
    /// List ucs blades
    /// </summary>
    /// <summary>
    /// List ucs blades
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<UcsBladeResponse> ListUcsBlades(ListUcsBladesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<UcsBladeResponse> ListUcsBlades(ListUcsBladesRequest request) => _proxy.Request<ListResponse<UcsBladeResponse>>(request);
    }
}
