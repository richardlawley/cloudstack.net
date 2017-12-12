using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListSnapshotsRequest : APIListRequest
    {
        public ListSnapshotsRequest() : base("listSnapshots") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// lists snapshot by snapshot ID
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// valid values are HOURLY, DAILY, WEEKLY, and MONTHLY.
        /// </summary>
        public string IntervalType {
            get { return GetParameterValue<string>(nameof(IntervalType).ToLower()); }
            set { SetParameterValue(nameof(IntervalType).ToLower(), value); }
        }

        /// <summary>
        /// defaults to false, but if true, lists all resources from the parent specified by the domainId till leaves.
        /// </summary>
        public bool? Isrecursive {
            get { return GetParameterValue<bool?>(nameof(Isrecursive).ToLower()); }
            set { SetParameterValue(nameof(Isrecursive).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// If set to false, list only resources belonging to the command's caller; if set to true - list resources that the caller is authorized to see. Default value is false
        /// </summary>
        public bool? ListAll {
            get { return GetParameterValue<bool?>(nameof(ListAll).ToLower()); }
            set { SetParameterValue(nameof(ListAll).ToLower(), value); }
        }

        /// <summary>
        /// lists snapshot by snapshot name
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// list objects by project
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// valid values are MANUAL or RECURRING.
        /// </summary>
        public string SnapshotType {
            get { return GetParameterValue<string>(nameof(SnapshotType).ToLower()); }
            set { SetParameterValue(nameof(SnapshotType).ToLower(), value); }
        }

        /// <summary>
        /// List resources by tags (key/value pairs)
        /// </summary>
        public IList<IDictionary<string, object>> Tags {
            get { return GetList<IDictionary<string, object>>(nameof(Tags).ToLower()); }
            set { SetParameterValue(nameof(Tags).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the disk volume
        /// </summary>
        public Guid? VolumeId {
            get { return GetParameterValue<Guid?>(nameof(VolumeId).ToLower()); }
            set { SetParameterValue(nameof(VolumeId).ToLower(), value); }
        }

        /// <summary>
        /// list snapshots by zone id
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists all available snapshots for the account.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<SnapshotResponse> ListSnapshots(ListSnapshotsRequest request);
        Task<ListResponse<SnapshotResponse>> ListSnapshotsAsync(ListSnapshotsRequest request);
        ListResponse<SnapshotResponse> ListSnapshotsAllPages(ListSnapshotsRequest request);
        Task<ListResponse<SnapshotResponse>> ListSnapshotsAllPagesAsync(ListSnapshotsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<SnapshotResponse> ListSnapshots(ListSnapshotsRequest request) => Proxy.Request<ListResponse<SnapshotResponse>>(request);
        public Task<ListResponse<SnapshotResponse>> ListSnapshotsAsync(ListSnapshotsRequest request) => Proxy.RequestAsync<ListResponse<SnapshotResponse>>(request);
        public ListResponse<SnapshotResponse> ListSnapshotsAllPages(ListSnapshotsRequest request) => Proxy.RequestAllPages<SnapshotResponse>(request);
        public Task<ListResponse<SnapshotResponse>> ListSnapshotsAllPagesAsync(ListSnapshotsRequest request) => Proxy.RequestAllPagesAsync<SnapshotResponse>(request);
    }
}
