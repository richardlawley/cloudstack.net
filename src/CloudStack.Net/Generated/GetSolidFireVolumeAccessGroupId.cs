using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
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
            get { return GetParameterValue<string>(nameof(Clusterid).ToLower()); }
            set { SetParameterValue(nameof(Clusterid).ToLower(), value); }
        }

        /// <summary>
        /// Storage Pool UUID
        /// </summary>
        public string Storageid {
            get { return GetParameterValue<string>(nameof(Storageid).ToLower()); }
            set { SetParameterValue(nameof(Storageid).ToLower(), value); }
        }

    }
    /// <summary>
    /// Get the SF Volume Access Group ID
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ApiSolidFireVolumeAccessGroupIdResponse GetSolidFireVolumeAccessGroupId(GetSolidFireVolumeAccessGroupIdRequest request);
        Task<ApiSolidFireVolumeAccessGroupIdResponse> GetSolidFireVolumeAccessGroupIdAsync(GetSolidFireVolumeAccessGroupIdRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ApiSolidFireVolumeAccessGroupIdResponse GetSolidFireVolumeAccessGroupId(GetSolidFireVolumeAccessGroupIdRequest request) => Proxy.Request<ApiSolidFireVolumeAccessGroupIdResponse>(request);
        public Task<ApiSolidFireVolumeAccessGroupIdResponse> GetSolidFireVolumeAccessGroupIdAsync(GetSolidFireVolumeAccessGroupIdRequest request) => Proxy.RequestAsync<ApiSolidFireVolumeAccessGroupIdResponse>(request);
    }
}
