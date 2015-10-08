using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListTagsRequest : APIRequest
    {
        public ListTagsRequest() : base("listTags") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// list by customer name
        /// </summary>
        public string Customer { get; set; }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// defaults to false, but if true, lists all resources from the parent specified by the domainId till leaves.
        /// </summary>
        public bool? Recursive { get; set; }

        /// <summary>
        /// list by key
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// If set to false, list only resources belonging to the command's caller; if set to true - list resources that the caller is authorized to see. Default value is false
        /// </summary>
        public bool? ListAll { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// list objects by project
        /// </summary>
        public Guid ProjectId { get; set; }

        /// <summary>
        /// list by resource id
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// list by resource type
        /// </summary>
        public string ResourceType { get; set; }

        /// <summary>
        /// list by value
        /// </summary>
        public string Value { get; set; }

    }
    /// <summary>
    /// List resource tag(s)
    /// </summary>
    /// <summary>
    /// List resource tag(s)
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ResourceTagResponse> ListTags(ListTagsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ResourceTagResponse> ListTags(ListTagsRequest request) => _proxy.Request<ListResponse<ResourceTagResponse>>(request);
    }
}
