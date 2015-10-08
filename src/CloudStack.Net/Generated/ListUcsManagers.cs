using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListUcsManagersRequest : APIRequest
    {
        public ListUcsManagersRequest() : base("listUcsManagers") {}

        /// <summary>
        /// the ID of the ucs manager
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// the zone id
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// List ucs manager
    /// </summary>
    /// <summary>
    /// List ucs manager
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<UcsManagerResponse> ListUcsManagers(ListUcsManagersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<UcsManagerResponse> ListUcsManagers(ListUcsManagersRequest request) => _proxy.Request<ListResponse<UcsManagerResponse>>(request);
    }
}
