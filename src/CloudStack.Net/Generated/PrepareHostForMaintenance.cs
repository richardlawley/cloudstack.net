using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Prepares a host for maintenance.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse PrepareHostForMaintenance(PrepareHostForMaintenanceRequest request);
        Task<AsyncJobResponse> PrepareHostForMaintenanceAsync(PrepareHostForMaintenanceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse PrepareHostForMaintenance(PrepareHostForMaintenanceRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> PrepareHostForMaintenanceAsync(PrepareHostForMaintenanceRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
