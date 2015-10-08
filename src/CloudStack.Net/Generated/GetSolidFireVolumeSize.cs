using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class GetSolidFireVolumeSizeRequest : APIRequest
    {
        public GetSolidFireVolumeSizeRequest() : base("getSolidFireVolumeSize") {}

        /// <summary>
        /// Storage Pool UUID
        /// </summary>
        public string StoragePoolUuid { get; set; }

        /// <summary>
        /// Volume UUID
        /// </summary>
        public string VolumeUuid { get; set; }

    }
    /// <summary>
    /// Get the SF volume size including Hypervisor Snapshot Reserve
    /// </summary>
    /// <summary>
    /// Get the SF volume size including Hypervisor Snapshot Reserve
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ApiSolidFireVolumeSizeResponse GetSolidFireVolumeSize(GetSolidFireVolumeSizeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ApiSolidFireVolumeSizeResponse GetSolidFireVolumeSize(GetSolidFireVolumeSizeRequest request) => _proxy.Request<ApiSolidFireVolumeSizeResponse>(request);
    }
}
