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
        public string Clusterid {
            get { return (string) Parameters[nameof(Clusterid).ToLower()]; }
            set { Parameters[nameof(Clusterid).ToLower()] = value; }
        }

        /// <summary>
        /// Storage Pool UUID
        /// </summary>
        public string Storageid {
            get { return (string) Parameters[nameof(Storageid).ToLower()]; }
            set { Parameters[nameof(Storageid).ToLower()] = value; }
        }

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
