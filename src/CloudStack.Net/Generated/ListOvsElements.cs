using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListOvsElementsRequest : APIRequest
    {
        public ListOvsElementsRequest() : base("listOvsElements") {}

        /// <summary>
        /// list network offerings by enabled state
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// list ovs elements by id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// list ovs elements by network service provider id
        /// </summary>
        public Guid NspId { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

    }
    /// <summary>
    /// Lists all available ovs elements.
    /// </summary>
    /// <summary>
    /// Lists all available ovs elements.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<OvsProviderResponse> ListOvsElements(ListOvsElementsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<OvsProviderResponse> ListOvsElements(ListOvsElementsRequest request) => _proxy.Request<ListResponse<OvsProviderResponse>>(request);
    }
}
