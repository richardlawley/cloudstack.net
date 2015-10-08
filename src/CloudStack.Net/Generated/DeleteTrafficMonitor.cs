using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteTrafficMonitorRequest : APIRequest
    {
        public DeleteTrafficMonitorRequest() : base("deleteTrafficMonitor") {}

        /// <summary>
        /// Id of the Traffic Monitor Host.
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Deletes an traffic monitor host.
    /// </summary>
    /// <summary>
    /// Deletes an traffic monitor host.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteTrafficMonitor(DeleteTrafficMonitorRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteTrafficMonitor(DeleteTrafficMonitorRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
