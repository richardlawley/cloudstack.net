using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CancelStorageMaintenanceRequest : APIRequest
    {
        public CancelStorageMaintenanceRequest() : base("cancelStorageMaintenance") {}

        /// <summary>
        /// the primary storage ID
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Cancels maintenance for primary storage
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CancelStorageMaintenance(CancelStorageMaintenanceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CancelStorageMaintenance(CancelStorageMaintenanceRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
