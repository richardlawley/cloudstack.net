using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteSnapshotPoliciesRequest : APIRequest
    {
        public DeleteSnapshotPoliciesRequest() : base("deleteSnapshotPolicies") {}

        /// <summary>
        /// the Id of the snapshot policy
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// list of snapshots policy IDs separated by comma
        /// </summary>
        public IList<Guid> Ids {
            get { return (IList<Guid>) Parameters[nameof(Ids).ToLower()]; }
            set { Parameters[nameof(Ids).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Deletes snapshot policies for the account.
    /// </summary>
    /// <summary>
    /// Deletes snapshot policies for the account.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteSnapshotPolicies(DeleteSnapshotPoliciesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteSnapshotPolicies(DeleteSnapshotPoliciesRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
