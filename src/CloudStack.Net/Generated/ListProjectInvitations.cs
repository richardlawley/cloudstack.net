using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListProjectInvitationsRequest : APIRequest
    {
        public ListProjectInvitationsRequest() : base("listProjectInvitations") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// if true, list only active invitations - having Pending state and ones that are not timed out yet
        /// </summary>
        public bool? ActiveOnly { get; set; }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// list invitations by id
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

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// list by project id
        /// </summary>
        public Guid ProjectId { get; set; }

        /// <summary>
        /// list invitations by state
        /// </summary>
        public string State { get; set; }

    }
    /// <summary>
    /// Lists project invitations and provides detailed information for listed invitations
    /// </summary>
    /// <summary>
    /// Lists project invitations and provides detailed information for listed invitations
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ProjectInvitationResponse> ListProjectInvitations(ListProjectInvitationsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ProjectInvitationResponse> ListProjectInvitations(ListProjectInvitationsRequest request) => _proxy.Request<ListResponse<ProjectInvitationResponse>>(request);
    }
}
