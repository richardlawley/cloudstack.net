using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RevertSnapshotRequest : APIRequest
    {
        public RevertSnapshotRequest() : base("revertSnapshot") {}

        /// <summary>
        /// The ID of the snapshot
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// revert a volume snapshot.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse RevertSnapshot(RevertSnapshotRequest request);
        Task<AsyncJobResponse> RevertSnapshotAsync(RevertSnapshotRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse RevertSnapshot(RevertSnapshotRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> RevertSnapshotAsync(RevertSnapshotRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
