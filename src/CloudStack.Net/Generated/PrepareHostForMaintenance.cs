using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class PrepareHostForMaintenanceRequest : APIRequest
    {
        public PrepareHostForMaintenanceRequest() : base("prepareHostForMaintenance") {}

        /// <summary>
        /// the host ID
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Prepares a host for maintenance.
    /// </summary>
    /// <summary>
    /// Prepares a host for maintenance.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse PrepareHostForMaintenance(PrepareHostForMaintenanceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse PrepareHostForMaintenance(PrepareHostForMaintenanceRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
