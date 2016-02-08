using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListSnapshotPoliciesRequest : APIRequest
    {
        public ListSnapshotPoliciesRequest() : base("listSnapshotPolicies") {}

        /// <summary>
        /// list resources by display flag; only ROOT admin is eligible to pass this parameter
        /// </summary>
        public bool? Fordisplay {
            get { return (bool?) Parameters[nameof(Fordisplay).ToLower()]; }
            set { Parameters[nameof(Fordisplay).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the snapshot policy
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        public int? Page {
            get { return (int?) Parameters[nameof(Page).ToLower()]; }
            set { Parameters[nameof(Page).ToLower()] = value; }
        }

        public int? PageSize {
            get { return (int?) Parameters[nameof(PageSize).ToLower()]; }
            set { Parameters[nameof(PageSize).ToLower()] = value; }
        }

        /// <summary>
        /// the ID of the disk volume
        /// </summary>
        public Guid VolumeId {
            get { return (Guid) Parameters[nameof(VolumeId).ToLower()]; }
            set { Parameters[nameof(VolumeId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists snapshot policies.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<SnapshotPolicyResponse> ListSnapshotPolicies(ListSnapshotPoliciesRequest request);
        Task<ListResponse<SnapshotPolicyResponse>> ListSnapshotPoliciesAsync(ListSnapshotPoliciesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<SnapshotPolicyResponse> ListSnapshotPolicies(ListSnapshotPoliciesRequest request) => _proxy.Request<ListResponse<SnapshotPolicyResponse>>(request);
        public Task<ListResponse<SnapshotPolicyResponse>> ListSnapshotPoliciesAsync(ListSnapshotPoliciesRequest request) => _proxy.RequestAsync<ListResponse<SnapshotPolicyResponse>>(request);
    }
}
