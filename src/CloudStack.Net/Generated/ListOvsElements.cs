using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListOvsElementsRequest : APIListRequest
    {
        public ListOvsElementsRequest() : base("listOvsElements") {}

        /// <summary>
        /// list network offerings by enabled state
        /// </summary>
        public bool? Enabled {
            get { return GetParameterValue<bool?>(nameof(Enabled).ToLower()); }
            set { SetParameterValue(nameof(Enabled).ToLower(), value); }
        }

        /// <summary>
        /// list ovs elements by id
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
        /// list ovs elements by network service provider id
        /// </summary>
        public Guid? NspId {
            get { return GetParameterValue<Guid?>(nameof(NspId).ToLower()); }
            set { SetParameterValue(nameof(NspId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists all available ovs elements.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<OvsProviderResponse> ListOvsElements(ListOvsElementsRequest request);
        Task<ListResponse<OvsProviderResponse>> ListOvsElementsAsync(ListOvsElementsRequest request);
        ListResponse<OvsProviderResponse> ListOvsElementsAllPages(ListOvsElementsRequest request);
        Task<ListResponse<OvsProviderResponse>> ListOvsElementsAllPagesAsync(ListOvsElementsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<OvsProviderResponse> ListOvsElements(ListOvsElementsRequest request) => _proxy.Request<ListResponse<OvsProviderResponse>>(request);
        public Task<ListResponse<OvsProviderResponse>> ListOvsElementsAsync(ListOvsElementsRequest request) => _proxy.RequestAsync<ListResponse<OvsProviderResponse>>(request);
        public ListResponse<OvsProviderResponse> ListOvsElementsAllPages(ListOvsElementsRequest request) => _proxy.RequestAllPages<OvsProviderResponse>(request);
        public Task<ListResponse<OvsProviderResponse>> ListOvsElementsAllPagesAsync(ListOvsElementsRequest request) => _proxy.RequestAllPagesAsync<OvsProviderResponse>(request);
    }
}
