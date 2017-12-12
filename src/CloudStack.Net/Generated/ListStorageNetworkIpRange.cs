using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListStorageNetworkIpRangeRequest : APIListRequest
    {
        public ListStorageNetworkIpRangeRequest() : base("listStorageNetworkIpRange") {}

        /// <summary>
        /// optional parameter. Storaget network IP range uuid, if specicied, using it to search the range.
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// optional parameter. Pod uuid, if specicied and range uuid is absent, using it to search the range.
        /// </summary>
        public Guid? PodId {
            get { return GetParameterValue<Guid?>(nameof(PodId).ToLower()); }
            set { SetParameterValue(nameof(PodId).ToLower(), value); }
        }

        /// <summary>
        /// optional parameter. Zone uuid, if specicied and both pod uuid and range uuid are absent, using it to search the range.
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// List a storage network IP range.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<StorageNetworkIpRangeResponse> ListStorageNetworkIpRange(ListStorageNetworkIpRangeRequest request);
        Task<ListResponse<StorageNetworkIpRangeResponse>> ListStorageNetworkIpRangeAsync(ListStorageNetworkIpRangeRequest request);
        ListResponse<StorageNetworkIpRangeResponse> ListStorageNetworkIpRangeAllPages(ListStorageNetworkIpRangeRequest request);
        Task<ListResponse<StorageNetworkIpRangeResponse>> ListStorageNetworkIpRangeAllPagesAsync(ListStorageNetworkIpRangeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<StorageNetworkIpRangeResponse> ListStorageNetworkIpRange(ListStorageNetworkIpRangeRequest request) => Proxy.Request<ListResponse<StorageNetworkIpRangeResponse>>(request);
        public Task<ListResponse<StorageNetworkIpRangeResponse>> ListStorageNetworkIpRangeAsync(ListStorageNetworkIpRangeRequest request) => Proxy.RequestAsync<ListResponse<StorageNetworkIpRangeResponse>>(request);
        public ListResponse<StorageNetworkIpRangeResponse> ListStorageNetworkIpRangeAllPages(ListStorageNetworkIpRangeRequest request) => Proxy.RequestAllPages<StorageNetworkIpRangeResponse>(request);
        public Task<ListResponse<StorageNetworkIpRangeResponse>> ListStorageNetworkIpRangeAllPagesAsync(ListStorageNetworkIpRangeRequest request) => Proxy.RequestAllPagesAsync<StorageNetworkIpRangeResponse>(request);
    }
}
