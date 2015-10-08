using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class GetSolidFireVolumeAccessGroupIdRequest : APIRequest
    {
        public GetSolidFireVolumeAccessGroupIdRequest() : base("getSolidFireVolumeAccessGroupId") {}

        /// <summary>
        /// Cluster UUID
        /// </summary>
        public string ClusterUuid { get; set; }

        /// <summary>
        /// Storage Pool UUID
        /// </summary>
        public string StoragePoolUuid { get; set; }

    }
    /// <summary>
    /// Get the SF Volume Access Group ID
    /// </summary>
    /// <summary>
    /// Get the SF Volume Access Group ID
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ApiSolidFireVolumeAccessGroupIdResponse GetSolidFireVolumeAccessGroupId(GetSolidFireVolumeAccessGroupIdRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ApiSolidFireVolumeAccessGroupIdResponse GetSolidFireVolumeAccessGroupId(GetSolidFireVolumeAccessGroupIdRequest request) => _proxy.Request<ApiSolidFireVolumeAccessGroupIdResponse>(request);
    }
}
