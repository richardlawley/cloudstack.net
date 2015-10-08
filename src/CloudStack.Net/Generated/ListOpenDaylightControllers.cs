using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListOpenDaylightControllersRequest : APIRequest
    {
        public ListOpenDaylightControllersRequest() : base("listOpenDaylightControllers") {}

        /// <summary>
        /// the ID of a OpenDaylight Controller
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId { get; set; }

    }
    /// <summary>
    /// Lists OpenDyalight controllers
    /// </summary>
    /// <summary>
    /// Lists OpenDyalight controllers
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        OpenDaylightControllerResponse ListOpenDaylightControllers(ListOpenDaylightControllersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public OpenDaylightControllerResponse ListOpenDaylightControllers(ListOpenDaylightControllersRequest request) => _proxy.Request<OpenDaylightControllerResponse>(request);
    }
}
