using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Puts storage pool into maintenance state
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse EnableStorageMaintenance(EnableStorageMaintenanceRequest request);
        Task<AsyncJobResponse> EnableStorageMaintenanceAsync(EnableStorageMaintenanceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse EnableStorageMaintenance(EnableStorageMaintenanceRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> EnableStorageMaintenanceAsync(EnableStorageMaintenanceRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
