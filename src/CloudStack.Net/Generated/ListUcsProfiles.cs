using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListUcsProfilesRequest : APIRequest
    {
        public ListUcsProfilesRequest() : base("listUcsProfiles") {}

        /// <summary>
        /// the id for the ucs manager
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
    /// List profile in ucs manager
    /// </summary>
    /// <summary>
    /// List profile in ucs manager
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<UcsProfileResponse> ListUcsProfiles(ListUcsProfilesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<UcsProfileResponse> ListUcsProfiles(ListUcsProfilesRequest request) => _proxy.Request<ListResponse<UcsProfileResponse>>(request);
    }
}
