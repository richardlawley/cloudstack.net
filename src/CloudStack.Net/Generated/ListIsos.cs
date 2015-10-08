using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListIsosRequest : APIRequest
    {
        public ListIsosRequest() : base("listIsos") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// true if the ISO is bootable, false otherwise
        /// </summary>
        public bool? Bootable { get; set; }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// the hypervisor for which to restrict the search
        /// </summary>
        public string Hypervisor { get; set; }

        /// <summary>
        /// list ISO by ID
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// possible values are "featured", "self", "selfexecutable","sharedexecutable","executable", and "community". * featured : templates that have been marked as featured and public. * self : templates that have been registered or created by the calling user. * selfexecutable : same as self, but only returns templates that can be used to deploy a new VM. * sharedexecutable : templates ready to be deployed that have been granted to the calling user by another user. * executable : templates that are owned by the calling user, or public templates, that can be used to deploy a VM. * community : templates that have been marked as public but not featured. * all : all templates (only usable by admins).
        /// </summary>
        public string IsoFilter { get; set; }

        /// <summary>
        /// true if the ISO is publicly available to all users, false otherwise.
        /// </summary>
        public bool? PublicIso { get; set; }

        /// <summary>
        /// true if this ISO is ready to be deployed
        /// </summary>
        public bool? Ready { get; set; }

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
        /// list all ISOs by name
        /// </summary>
        public string IsoName { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// list objects by project
        /// </summary>
        public Guid ProjectId { get; set; }

        /// <summary>
        /// show removed ISOs as well
        /// </summary>
        public bool? ShowRemoved { get; set; }

        /// <summary>
        /// List resources by tags (key/value pairs)
        /// </summary>
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// the ID of the zone
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// Lists all available ISO files.
    /// </summary>
    /// <summary>
    /// Lists all available ISO files.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<TemplateResponse> ListIsos(ListIsosRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<TemplateResponse> ListIsos(ListIsosRequest request) => _proxy.Request<ListResponse<TemplateResponse>>(request);
    }
}
