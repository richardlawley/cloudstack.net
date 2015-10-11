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
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Deletes project invitation
    /// </summary>
    /// <summary>
    /// Deletes project invitation
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteProjectInvitation(DeleteProjectInvitationRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteProjectInvitation(DeleteProjectInvitationRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
