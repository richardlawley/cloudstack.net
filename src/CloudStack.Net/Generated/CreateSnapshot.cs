using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateSnapshotRequest : APIRequest
    {
        public CreateSnapshotRequest() : base("createSnapshot") {}

        /// <summary>
        /// The ID of the disk volume
        /// </summary>
        public Guid VolumeId {
            get { return GetParameterValue<Guid>(nameof(VolumeId).ToLower()); }
            set { SetParameterValue(nameof(VolumeId).ToLower(), value); }
        }

        /// <summary>
        /// The account of the snapshot. The account parameter must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// The domain ID of the snapshot. If used with the account parameter, specifies a domain for the account associated with the disk volume.
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// the name of the snapshot
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// policy id of the snapshot, if this is null, then use MANUAL_POLICY.
        /// </summary>
        public Guid? PolicyId {
            get { return GetParameterValue<Guid?>(nameof(PolicyId).ToLower()); }
            set { SetParameterValue(nameof(PolicyId).ToLower(), value); }
        }

        /// <summary>
        /// quiesce vm if true
        /// </summary>
        public bool? Quiescevm {
            get { return GetParameterValue<bool?>(nameof(Quiescevm).ToLower()); }
            set { SetParameterValue(nameof(Quiescevm).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates an instant snapshot of a volume.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateSnapshot(CreateSnapshotRequest request);
        Task<AsyncJobResponse> CreateSnapshotAsync(CreateSnapshotRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateSnapshot(CreateSnapshotRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateSnapshotAsync(CreateSnapshotRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
