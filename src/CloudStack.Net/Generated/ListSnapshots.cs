using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListSnapshotsRequest : APIRequest
    {
        public ListSnapshotsRequest() : base("listSnapshots") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid DomainId { get; set; }

        /// <summary>
        /// lists snapshot by snapshot ID
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// valid values are HOURLY, DAILY, WEEKLY, and MONTHLY.
        /// </summary>
        public string IntervalType { get; set; }

        /// <summary>
        /// defaults to false, but if true, lists all resources from the parent specified by the domainId till leaves.
        /// </summary>
        public bool? Recursive { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// If set to false, list only resources belonging to the command's caller; if set to true - list resources that the caller is authorized to see. Default value is false
        /// </summary>
        public bool? ListAll { get; set; }

        /// <summary>
        /// lists snapshot by snapshot name
        /// </summary>
        public string SnapshotName { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// list objects by project
        /// </summary>
        public Guid ProjectId { get; set; }

        /// <summary>
        /// valid values are MANUAL or RECURRING.
        /// </summary>
        public string SnapshotType { get; set; }

        /// <summary>
        /// List resources by tags (key/value pairs)
        /// </summary>
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// the ID of the disk volume
        /// </summary>
        public Guid VolumeId { get; set; }

        /// <summary>
        /// list snapshots by zone id
        /// </summary>
        public Guid ZoneId { get; set; }

    }
    /// <summary>
    /// Lists all available snapshots for the account.
    /// </summary>
    /// <summary>
    /// Lists all available snapshots for the account.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<SnapshotResponse> ListSnapshots(ListSnapshotsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<SnapshotResponse> ListSnapshots(ListSnapshotsRequest request) => _proxy.Request<ListResponse<SnapshotResponse>>(request);
    }
}
