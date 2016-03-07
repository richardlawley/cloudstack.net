using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListSwiftsRequest : APIListRequest
    {
        public ListSwiftsRequest() : base("listSwifts") {}

        /// <summary>
        /// the id of the swift
        /// </summary>
        public long? Id {
            get { return (long?) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

    }
    /// <summary>
    /// List Swift.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ImageStoreResponse> ListSwifts(ListSwiftsRequest request);
        Task<ListResponse<ImageStoreResponse>> ListSwiftsAsync(ListSwiftsRequest request);
        ListResponse<ImageStoreResponse> ListSwiftsAllPages(ListSwiftsRequest request);
        Task<ListResponse<ImageStoreResponse>> ListSwiftsAllPagesAsync(ListSwiftsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ImageStoreResponse> ListSwifts(ListSwiftsRequest request) => _proxy.Request<ListResponse<ImageStoreResponse>>(request);
        public Task<ListResponse<ImageStoreResponse>> ListSwiftsAsync(ListSwiftsRequest request) => _proxy.RequestAsync<ListResponse<ImageStoreResponse>>(request);
        public ListResponse<ImageStoreResponse> ListSwiftsAllPages(ListSwiftsRequest request) => _proxy.RequestAllPages<ImageStoreResponse>(request);
        public Task<ListResponse<ImageStoreResponse>> ListSwiftsAllPagesAsync(ListSwiftsRequest request) => _proxy.RequestAllPagesAsync<ImageStoreResponse>(request);
    }
}
