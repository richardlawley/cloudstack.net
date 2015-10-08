using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListBrocadeVcsDevicesRequest : APIRequest
    {
        public ListBrocadeVcsDevicesRequest() : base("listBrocadeVcsDevices") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword { get; set; }

        public int? Page { get; set; }

        public int? PageSize { get; set; }

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId { get; set; }

        /// <summary>
        /// Brocade VCS switch ID
        /// </summary>
        public Guid BrocadeVcsDeviceId { get; set; }

    }
    /// <summary>
    /// Lists Brocade VCS Switches
    /// </summary>
    /// <summary>
    /// Lists Brocade VCS Switches
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<BrocadeVcsDeviceResponse> ListBrocadeVcsDevices(ListBrocadeVcsDevicesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<BrocadeVcsDeviceResponse> ListBrocadeVcsDevices(ListBrocadeVcsDevicesRequest request) => _proxy.Request<ListResponse<BrocadeVcsDeviceResponse>>(request);
    }
}
