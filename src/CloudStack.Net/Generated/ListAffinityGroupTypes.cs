using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListAffinityGroupTypesRequest : APIRequest
    {
        public ListAffinityGroupTypesRequest() : base("listAffinityGroupTypes") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

    }
    /// <summary>
    /// Lists affinity group types available
    /// </summary>
    /// <summary>
    /// Lists affinity group types available
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<AffinityGroupTypeResponse> ListAffinityGroupTypes(ListAffinityGroupTypesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<AffinityGroupTypeResponse> ListAffinityGroupTypes(ListAffinityGroupTypesRequest request) => _proxy.Request<ListResponse<AffinityGroupTypeResponse>>(request);
    }
}
