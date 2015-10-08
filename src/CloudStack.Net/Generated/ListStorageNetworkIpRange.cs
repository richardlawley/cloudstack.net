using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListStorageNetworkIpRangeRequest : APIRequest
    {
        public ListStorageNetworkIpRangeRequest() : base("listStorageNetworkIpRange") {}

        /// <summary>
        /// optional parameter. Storaget network IP range uuid, if specicied, using it to search the range.
        /// </summary>
        public Guid RangeId { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// optional parameter. Pod uuid, if specicied and range uuid is absent, using it to search the range.
        /// </summary>
        public Guid PodId { get; set; }

        /// <summary>
        /// optional parameter. Zone uuid, if specicied and both pod uuid and range uuid are absent, using it to search the range.
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// List a storage network IP range.
    /// </summary>
    /// <summary>
    /// List a storage network IP range.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<StorageNetworkIpRangeResponse> ListStorageNetworkIpRange(ListStorageNetworkIpRangeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<StorageNetworkIpRangeResponse> ListStorageNetworkIpRange(ListStorageNetworkIpRangeRequest request) => _proxy.Request<ListResponse<StorageNetworkIpRangeResponse>>(request);
    }
}
