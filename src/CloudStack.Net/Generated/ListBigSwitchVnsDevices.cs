using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListBigSwitchVnsDevicesRequest : APIRequest
    {
        public ListBigSwitchVnsDevicesRequest() : base("listBigSwitchVnsDevices") {}

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
        /// bigswitch vns device ID
        /// </summary>
        public Guid Vnsdeviceid {
            get { return (Guid) Parameters[nameof(Vnsdeviceid).ToLower()]; }
            set { Parameters[nameof(Vnsdeviceid).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists BigSwitch Vns devices
    /// </summary>
    /// <summary>
    /// Lists BigSwitch Vns devices
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<BigSwitchVnsDeviceResponse> ListBigSwitchVnsDevices(ListBigSwitchVnsDevicesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<BigSwitchVnsDeviceResponse> ListBigSwitchVnsDevices(ListBigSwitchVnsDevicesRequest request) => _proxy.Request<ListResponse<BigSwitchVnsDeviceResponse>>(request);
    }
}
