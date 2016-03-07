using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListTrafficTypeImplementorsRequest : APIListRequest
    {
        public ListTrafficTypeImplementorsRequest() : base("listTrafficTypeImplementors") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        /// <summary>
        /// Optional. The network traffic type, if specified, return its implementor. Otherwise, return all traffic types with their implementor
        /// </summary>
        public string TrafficType {
            get { return (string) Parameters[nameof(TrafficType).ToLower()]; }
            set { Parameters[nameof(TrafficType).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists implementors of implementor of a network traffic type or implementors of all network traffic types
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<TrafficTypeImplementorResponse> ListTrafficTypeImplementors(ListTrafficTypeImplementorsRequest request);
        Task<ListResponse<TrafficTypeImplementorResponse>> ListTrafficTypeImplementorsAsync(ListTrafficTypeImplementorsRequest request);
        ListResponse<TrafficTypeImplementorResponse> ListTrafficTypeImplementorsAllPages(ListTrafficTypeImplementorsRequest request);
        Task<ListResponse<TrafficTypeImplementorResponse>> ListTrafficTypeImplementorsAllPagesAsync(ListTrafficTypeImplementorsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<TrafficTypeImplementorResponse> ListTrafficTypeImplementors(ListTrafficTypeImplementorsRequest request) => _proxy.Request<ListResponse<TrafficTypeImplementorResponse>>(request);
        public Task<ListResponse<TrafficTypeImplementorResponse>> ListTrafficTypeImplementorsAsync(ListTrafficTypeImplementorsRequest request) => _proxy.RequestAsync<ListResponse<TrafficTypeImplementorResponse>>(request);
        public ListResponse<TrafficTypeImplementorResponse> ListTrafficTypeImplementorsAllPages(ListTrafficTypeImplementorsRequest request) => _proxy.RequestAllPages<TrafficTypeImplementorResponse>(request);
        public Task<ListResponse<TrafficTypeImplementorResponse>> ListTrafficTypeImplementorsAllPagesAsync(ListTrafficTypeImplementorsRequest request) => _proxy.RequestAllPagesAsync<TrafficTypeImplementorResponse>(request);
    }
}
