using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CancelHostMaintenanceRequest : APIRequest
    {
        public CancelHostMaintenanceRequest() : base("cancelHostMaintenance") {}

        /// <summary>
        /// the host ID
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Cancels host maintenance.
    /// </summary>
    /// <summary>
    /// Cancels host maintenance.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        HostResponse CancelHostMaintenance(CancelHostMaintenanceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public HostResponse CancelHostMaintenance(CancelHostMaintenanceRequest request) => _proxy.Request<HostResponse>(request);
    }
}
