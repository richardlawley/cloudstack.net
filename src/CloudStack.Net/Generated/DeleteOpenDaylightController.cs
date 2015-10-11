using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteOpenDaylightControllerRequest : APIRequest
    {
        public DeleteOpenDaylightControllerRequest() : base("deleteOpenDaylightController") {}

        /// <summary>
        /// OpenDaylight Controller ID
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Removes an OpenDyalight controler
    /// </summary>
    /// <summary>
    /// Removes an OpenDyalight controler
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        OpenDaylightControllerResponse DeleteOpenDaylightController(DeleteOpenDaylightControllerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public OpenDaylightControllerResponse DeleteOpenDaylightController(DeleteOpenDaylightControllerRequest request) => _proxy.Request<OpenDaylightControllerResponse>(request);
    }
}
