using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class EnableStorageMaintenanceRequest : APIRequest
    {
        public EnableStorageMaintenanceRequest() : base("enableStorageMaintenance") {}

        /// <summary>
        /// Primary storage ID
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Puts storage pool into maintenance state
    /// </summary>
    /// <summary>
    /// Puts storage pool into maintenance state
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse EnableStorageMaintenance(EnableStorageMaintenanceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse EnableStorageMaintenance(EnableStorageMaintenanceRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
