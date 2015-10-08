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
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Puts storage pool into maintenance state
    /// </summary>
    /// <summary>
    /// Puts storage pool into maintenance state
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        StoragePoolResponse EnableStorageMaintenance(EnableStorageMaintenanceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public StoragePoolResponse EnableStorageMaintenance(EnableStorageMaintenanceRequest request) => _proxy.Request<StoragePoolResponse>(request);
    }
}
