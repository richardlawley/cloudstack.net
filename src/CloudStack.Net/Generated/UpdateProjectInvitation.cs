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
            get { return GetParameterValue<Guid>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// if true, accept the invitation, decline if false. True by default
        /// </summary>
        public bool? Accept {
            get { return GetParameterValue<bool?>(nameof(Accept).ToLower()); }
            set { SetParameterValue(nameof(Accept).ToLower(), value); }
        }

        /// <summary>
        /// account that is joining the project
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// list invitations for specified account; this parameter has to be specified with domainId
        /// </summary>
        public string Token {
            get { return GetParameterValue<string>(nameof(Token).ToLower()); }
            set { SetParameterValue(nameof(Token).ToLower(), value); }
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
        public AsyncJobResponse UpdateProjectInvitation(UpdateProjectInvitationRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> UpdateProjectInvitationAsync(UpdateProjectInvitationRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
