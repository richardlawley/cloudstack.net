using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteProjectInvitationRequest : APIRequest
    {
        public DeleteProjectInvitationRequest() : base("deleteProjectInvitation") {}

        /// <summary>
        /// id of the invitation
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Deletes project invitation
    /// </summary>
    /// <summary>
    /// Deletes project invitation
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteProjectInvitation(DeleteProjectInvitationRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteProjectInvitation(DeleteProjectInvitationRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
