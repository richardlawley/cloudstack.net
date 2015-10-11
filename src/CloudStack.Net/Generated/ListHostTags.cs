using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListHostTagsRequest : APIRequest
    {
        public ListHostTagsRequest() : base("listHostTags") {}

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
    /// Lists host tags
    /// </summary>
    /// <summary>
    /// Lists host tags
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<HostTagResponse> ListHostTags(ListHostTagsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<HostTagResponse> ListHostTags(ListHostTagsRequest request) => _proxy.Request<ListResponse<HostTagResponse>>(request);
    }
}
