using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListProjectsRequest : APIRequest
    {
        public ListProjectsRequest() : base("listProjects") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// list projects by display text
        /// </summary>
        public string DisplayText { get; set; }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// list projects by project ID
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// defaults to false, but if true, lists all resources from the parent specified by the domainId till leaves.
        /// </summary>
        public bool? Recursive { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// If set to false, list only resources belonging to the command's caller; if set to true - list resources that the caller is authorized to see. Default value is false
        /// </summary>
        public bool? ListAll { get; set; }

        /// <summary>
        /// list projects by name
        /// </summary>
        public string Name { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// list projects by state
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// List projects by tags (key/value pairs)
        /// </summary>
        public IDictionary<string, string> Tags { get; set; }

    }
    /// <summary>
    /// Lists projects and provides detailed information for listed projects
    /// </summary>
    /// <summary>
    /// Lists projects and provides detailed information for listed projects
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ProjectResponse> ListProjects(ListProjectsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ProjectResponse> ListProjects(ListProjectsRequest request) => _proxy.Request<ListResponse<ProjectResponse>>(request);
    }
}
