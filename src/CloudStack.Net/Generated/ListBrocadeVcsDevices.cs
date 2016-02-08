using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListBrocadeVcsDevicesRequest : APIRequest
    {
        public ListBrocadeVcsDevicesRequest() : base("listBrocadeVcsDevices") {}

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
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId {
            get { return (Guid) Parameters[nameof(PhysicalNetworkId).ToLower()]; }
            set { Parameters[nameof(PhysicalNetworkId).ToLower()] = value; }
        }

        /// <summary>
        /// Brocade VCS switch ID
        /// </summary>
        public Guid Vcsdeviceid {
            get { return (Guid) Parameters[nameof(Vcsdeviceid).ToLower()]; }
            set { Parameters[nameof(Vcsdeviceid).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists Brocade VCS Switches
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<BrocadeVcsDeviceResponse> ListBrocadeVcsDevices(ListBrocadeVcsDevicesRequest request);
        Task<ListResponse<BrocadeVcsDeviceResponse>> ListBrocadeVcsDevicesAsync(ListBrocadeVcsDevicesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<BrocadeVcsDeviceResponse> ListBrocadeVcsDevices(ListBrocadeVcsDevicesRequest request) => _proxy.Request<ListResponse<BrocadeVcsDeviceResponse>>(request);
        public Task<ListResponse<BrocadeVcsDeviceResponse>> ListBrocadeVcsDevicesAsync(ListBrocadeVcsDevicesRequest request) => _proxy.RequestAsync<ListResponse<BrocadeVcsDeviceResponse>>(request);
    }
}
