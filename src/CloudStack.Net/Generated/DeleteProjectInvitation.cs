using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes project invitation
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteProjectInvitation(DeleteProjectInvitationRequest request);
        Task<AsyncJobResponse> DeleteProjectInvitationAsync(DeleteProjectInvitationRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteProjectInvitation(DeleteProjectInvitationRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteProjectInvitationAsync(DeleteProjectInvitationRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
