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
        public string Storageid {
            get { return (string) Parameters[nameof(Storageid).ToLower()]; }
            set { Parameters[nameof(Storageid).ToLower()] = value; }
        }

        /// <summary>
        /// Volume UUID
        /// </summary>
        public string Volumeid {
            get { return (string) Parameters[nameof(Volumeid).ToLower()]; }
            set { Parameters[nameof(Volumeid).ToLower()] = value; }
        }

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
