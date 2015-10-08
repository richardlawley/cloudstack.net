using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListSwiftsRequest : APIRequest
    {
        public ListSwiftsRequest() : base("listSwifts") {}

        /// <summary>
        /// the id of the swift
        /// </summary>
        public long? Id { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

    }
    /// <summary>
    /// List Swift.
    /// </summary>
    /// <summary>
    /// List Swift.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ImageStoreResponse> ListSwifts(ListSwiftsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ImageStoreResponse> ListSwifts(ListSwiftsRequest request) => _proxy.Request<ListResponse<ImageStoreResponse>>(request);
    }
}
