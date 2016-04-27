using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListProjectInvitationsRequest : APIListRequest
    {
        public ListProjectInvitationsRequest() : base("listProjectInvitations") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// if true, list only active invitations - having Pending state and ones that are not timed out yet
        /// </summary>
        public bool? ActiveOnly {
            get { return GetParameterValue<bool?>(nameof(ActiveOnly).ToLower()); }
            set { SetParameterValue(nameof(ActiveOnly).ToLower(), value); }
        }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// list invitations by id
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// defaults to false, but if true, lists all resources from the parent specified by the domainId till leaves.
        /// </summary>
        public bool? Isrecursive {
            get { return GetParameterValue<bool?>(nameof(Isrecursive).ToLower()); }
            set { SetParameterValue(nameof(Isrecursive).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// If set to false, list only resources belonging to the command's caller; if set to true - list resources that the caller is authorized to see. Default value is false
        /// </summary>
        public bool? ListAll {
            get { return GetParameterValue<bool?>(nameof(ListAll).ToLower()); }
            set { SetParameterValue(nameof(ListAll).ToLower(), value); }
        }

        /// <summary>
        /// list by project id
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// list invitations by state
        /// </summary>
        public string State {
            get { return GetParameterValue<string>(nameof(State).ToLower()); }
            set { SetParameterValue(nameof(State).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists project invitations and provides detailed information for listed invitations
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ProjectInvitationResponse> ListProjectInvitations(ListProjectInvitationsRequest request);
        Task<ListResponse<ProjectInvitationResponse>> ListProjectInvitationsAsync(ListProjectInvitationsRequest request);
        ListResponse<ProjectInvitationResponse> ListProjectInvitationsAllPages(ListProjectInvitationsRequest request);
        Task<ListResponse<ProjectInvitationResponse>> ListProjectInvitationsAllPagesAsync(ListProjectInvitationsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ProjectInvitationResponse> ListProjectInvitations(ListProjectInvitationsRequest request) => _proxy.Request<ListResponse<ProjectInvitationResponse>>(request);
        public Task<ListResponse<ProjectInvitationResponse>> ListProjectInvitationsAsync(ListProjectInvitationsRequest request) => _proxy.RequestAsync<ListResponse<ProjectInvitationResponse>>(request);
        public ListResponse<ProjectInvitationResponse> ListProjectInvitationsAllPages(ListProjectInvitationsRequest request) => _proxy.RequestAllPages<ProjectInvitationResponse>(request);
        public Task<ListResponse<ProjectInvitationResponse>> ListProjectInvitationsAllPagesAsync(ListProjectInvitationsRequest request) => _proxy.RequestAllPagesAsync<ProjectInvitationResponse>(request);
    }
}
