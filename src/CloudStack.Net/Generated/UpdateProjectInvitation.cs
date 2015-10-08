using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateProjectInvitationRequest : APIRequest
    {
        public UpdateProjectInvitationRequest() : base("updateProjectInvitation") {}

        /// <summary>
        /// id of the project to join
        /// </summary>
        public Guid ProjectId { get; set; }

        /// <summary>
        /// if true, accept the invitation, decline if false. True by default
        /// </summary>
        public bool? Accept { get; set; }

        /// <summary>
        /// account that is joining the project
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// list invitations for specified account; this parameter has to be specified with domainId
        /// </summary>
        public string Token { get; set; }

    }
    /// <summary>
    /// Accepts or declines project invitation
    /// </summary>
    /// <summary>
    /// Accepts or declines project invitation
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse UpdateProjectInvitation(UpdateProjectInvitationRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse UpdateProjectInvitation(UpdateProjectInvitationRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
