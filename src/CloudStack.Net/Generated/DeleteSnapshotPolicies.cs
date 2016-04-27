using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteSnapshotPoliciesRequest : APIRequest
    {
        public DeleteSnapshotPoliciesRequest() : base("deleteSnapshotPolicies") {}

        /// <summary>
        /// the Id of the snapshot policy
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// list of snapshots policy IDs separated by comma
        /// </summary>
        public IList<Guid> Ids {
            get { return GetList<Guid>(nameof(Ids).ToLower()); }
            set { SetParameterValue(nameof(Ids).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes snapshot policies for the account.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteSnapshotPolicies(DeleteSnapshotPoliciesRequest request);
        Task<SuccessResponse> DeleteSnapshotPoliciesAsync(DeleteSnapshotPoliciesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteSnapshotPolicies(DeleteSnapshotPoliciesRequest request) => _proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteSnapshotPoliciesAsync(DeleteSnapshotPoliciesRequest request) => _proxy.RequestAsync<SuccessResponse>(request);
    }
}
