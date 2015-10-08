using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListTemplatesRequest : APIRequest
    {
        public ListTemplatesRequest() : base("listTemplates") {}

        /// <summary>
        /// possible values are "featured", "self", "selfexecutable","sharedexecutable","executable", and "community". * featured : templates that have been marked as featured and public. * self : templates that have been registered or created by the calling user. * selfexecutable : same as self, but only returns templates that can be used to deploy a new VM. * sharedexecutable : templates ready to be deployed that have been granted to the calling user by another user. * executable : templates that are owned by the calling user, or public templates, that can be used to deploy a VM. * community : templates that have been marked as public but not featured. * all : all templates (only usable by admins).
        /// </summary>
        public string TemplateFilter { get; set; }

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// the hypervisor for which to restrict the search
        /// </summary>
        public string Hypervisor { get; set; }

        /// <summary>
        /// the template ID
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
        /// the template name
        /// </summary>
        public string TemplateName { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// list objects by project
        /// </summary>
        public Guid ProjectId { get; set; }

        /// <summary>
        /// show removed templates as well
        /// </summary>
        public bool? ShowRemoved { get; set; }

        /// <summary>
        /// List resources by tags (key/value pairs)
        /// </summary>
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// list templates by zoneId
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// List all public, private, and privileged templates.
    /// </summary>
    /// <summary>
    /// List all public, private, and privileged templates.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<TemplateResponse> ListTemplates(ListTemplatesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<TemplateResponse> ListTemplates(ListTemplatesRequest request) => _proxy.Request<ListResponse<TemplateResponse>>(request);
    }
}
