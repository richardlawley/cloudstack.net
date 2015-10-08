using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateSnapshotPolicyRequest : APIRequest
    {
        public UpdateSnapshotPolicyRequest() : base("updateSnapshotPolicy") {}

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId { get; set; }

        /// <summary>
        /// an optional field, whether to the display the snapshot policy to the end user or not.
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// the ID of the snapshot policy
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Updates the snapshot policy.
    /// </summary>
    /// <summary>
    /// Updates the snapshot policy.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SnapshotPolicyResponse UpdateSnapshotPolicy(UpdateSnapshotPolicyRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SnapshotPolicyResponse UpdateSnapshotPolicy(UpdateSnapshotPolicyRequest request) => _proxy.Request<SnapshotPolicyResponse>(request);
    }
}
