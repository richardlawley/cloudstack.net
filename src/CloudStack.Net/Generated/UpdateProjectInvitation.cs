using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateProjectInvitationRequest : APIRequest
    {
        public UpdateProjectInvitationRequest() : base("updateProjectInvitation") {}

        /// <summary>
        /// id of the project to join
        /// </summary>
        public Guid ProjectId {
            get { return (Guid) Parameters[nameof(ProjectId).ToLower()]; }
            set { Parameters[nameof(ProjectId).ToLower()] = value; }
        }

        /// <summary>
        /// if true, accept the invitation, decline if false. True by default
        /// </summary>
        public bool? Accept {
            get { return (bool?) Parameters[nameof(Accept).ToLower()]; }
            set { Parameters[nameof(Accept).ToLower()] = value; }
        }

        /// <summary>
        /// account that is joining the project
        /// </summary>
        public string Account {
            get { return (string) Parameters[nameof(Account).ToLower()]; }
            set { Parameters[nameof(Account).ToLower()] = value; }
        }

        /// <summary>
        /// list invitations for specified account; this parameter has to be specified with domainId
        /// </summary>
        public string Token {
            get { return (string) Parameters[nameof(Token).ToLower()]; }
            set { Parameters[nameof(Token).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Accepts or declines project invitation
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdateProjectInvitation(UpdateProjectInvitationRequest request);
        Task<AsyncJobResponse> UpdateProjectInvitationAsync(UpdateProjectInvitationRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdateProjectInvitation(UpdateProjectInvitationRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> UpdateProjectInvitationAsync(UpdateProjectInvitationRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
