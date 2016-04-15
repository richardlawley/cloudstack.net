using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListOpenDaylightControllersRequest : APIRequest
    {
        public ListOpenDaylightControllersRequest() : base("listOpenDaylightControllers") {}

        /// <summary>
        /// the ID of a OpenDaylight Controller
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId {
            get { return GetParameterValue<Guid>(nameof(PhysicalNetworkId).ToLower()); }
            set { SetParameterValue(nameof(PhysicalNetworkId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists OpenDyalight controllers
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        OpenDaylightControllerResponse ListOpenDaylightControllers(ListOpenDaylightControllersRequest request);
        Task<OpenDaylightControllerResponse> ListOpenDaylightControllersAsync(ListOpenDaylightControllersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public OpenDaylightControllerResponse ListOpenDaylightControllers(ListOpenDaylightControllersRequest request) => _proxy.Request<OpenDaylightControllerResponse>(request);
        public Task<OpenDaylightControllerResponse> ListOpenDaylightControllersAsync(ListOpenDaylightControllersRequest request) => _proxy.RequestAsync<OpenDaylightControllerResponse>(request);
    }
}
