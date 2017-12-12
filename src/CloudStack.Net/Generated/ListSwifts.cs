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
            get { return GetParameterValue<long?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
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
        public ListResponse<ImageStoreResponse> ListSwifts(ListSwiftsRequest request) => Proxy.Request<ListResponse<ImageStoreResponse>>(request);
        public Task<ListResponse<ImageStoreResponse>> ListSwiftsAsync(ListSwiftsRequest request) => Proxy.RequestAsync<ListResponse<ImageStoreResponse>>(request);
        public ListResponse<ImageStoreResponse> ListSwiftsAllPages(ListSwiftsRequest request) => Proxy.RequestAllPages<ImageStoreResponse>(request);
        public Task<ListResponse<ImageStoreResponse>> ListSwiftsAllPagesAsync(ListSwiftsRequest request) => Proxy.RequestAllPagesAsync<ImageStoreResponse>(request);
    }
}
