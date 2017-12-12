using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Cancels maintenance for primary storage
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CancelStorageMaintenance(CancelStorageMaintenanceRequest request);
        Task<AsyncJobResponse> CancelStorageMaintenanceAsync(CancelStorageMaintenanceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CancelStorageMaintenance(CancelStorageMaintenanceRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CancelStorageMaintenanceAsync(CancelStorageMaintenanceRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
