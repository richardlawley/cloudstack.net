using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListSnapshotPoliciesRequest : APIRequest
    {
        public ListSnapshotPoliciesRequest() : base("listSnapshotPolicies") {}

        /// <summary>
        /// list resources by display flag; only ROOT admin is eligible to pass this parameter
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// the ID of the snapshot policy
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// the ID of the disk volume
        /// </summary>
        public Guid VolumeId { get; set; }

    }
    /// <summary>
    /// Lists snapshot policies.
    /// </summary>
    /// <summary>
    /// Lists snapshot policies.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<SnapshotPolicyResponse> ListSnapshotPolicies(ListSnapshotPoliciesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<SnapshotPolicyResponse> ListSnapshotPolicies(ListSnapshotPoliciesRequest request) => _proxy.Request<ListResponse<SnapshotPolicyResponse>>(request);
    }
}
