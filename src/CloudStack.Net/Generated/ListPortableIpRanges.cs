using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListPortableIpRangesRequest : APIRequest
    {
        public ListPortableIpRangesRequest() : base("listPortableIpRanges") {}

        /// <summary>
        /// Id of the portable ip range
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// Id of a Region
        /// </summary>
        public int? RegionId { get; set; }

    }
    /// <summary>
    /// list portable IP ranges
    /// </summary>
    /// <summary>
    /// list portable IP ranges
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<PortableIpRangeResponse> ListPortableIpRanges(ListPortableIpRangesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<PortableIpRangeResponse> ListPortableIpRanges(ListPortableIpRangesRequest request) => _proxy.Request<ListResponse<PortableIpRangeResponse>>(request);
    }
}
