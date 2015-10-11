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
