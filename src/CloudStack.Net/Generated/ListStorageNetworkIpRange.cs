using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListStorageNetworkIpRangeRequest : APIRequest
    {
        public ListStorageNetworkIpRangeRequest() : base("listStorageNetworkIpRange") {}

        /// <summary>
        /// optional parameter. Storaget network IP range uuid, if specicied, using it to search the range.
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
        /// optional parameter. Pod uuid, if specicied and range uuid is absent, using it to search the range.
        /// </summary>
        public Guid PodId {
            get { return (Guid) Parameters[nameof(PodId).ToLower()]; }
            set { Parameters[nameof(PodId).ToLower()] = value; }
        }

        /// <summary>
        /// optional parameter. Zone uuid, if specicied and both pod uuid and range uuid are absent, using it to search the range.
        /// </summary>
        public Guid ZoneId {
            get { return (Guid) Parameters[nameof(ZoneId).ToLower()]; }
            set { Parameters[nameof(ZoneId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// List a storage network IP range.
    /// </summary>
    /// <summary>
    /// List a storage network IP range.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<StorageNetworkIpRangeResponse> ListStorageNetworkIpRange(ListStorageNetworkIpRangeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<StorageNetworkIpRangeResponse> ListStorageNetworkIpRange(ListStorageNetworkIpRangeRequest request) => _proxy.Request<ListResponse<StorageNetworkIpRangeResponse>>(request);
    }
}
