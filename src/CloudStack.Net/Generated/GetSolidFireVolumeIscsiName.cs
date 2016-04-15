using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class GetSolidFireVolumeIscsiNameRequest : APIRequest
    {
        public GetSolidFireVolumeIscsiNameRequest() : base("getSolidFireVolumeIscsiName") {}

        /// <summary>
        /// CloudStack Volume UUID
        /// </summary>
        public string Volumeid {
            get { return GetParameterValue<string>(nameof(Volumeid).ToLower()); }
            set { SetParameterValue(nameof(Volumeid).ToLower(), value); }
        }

    }
    /// <summary>
    /// Get SolidFire Volume's Iscsi Name
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ApiSolidFireVolumeIscsiNameResponse GetSolidFireVolumeIscsiName(GetSolidFireVolumeIscsiNameRequest request);
        Task<ApiSolidFireVolumeIscsiNameResponse> GetSolidFireVolumeIscsiNameAsync(GetSolidFireVolumeIscsiNameRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ApiSolidFireVolumeIscsiNameResponse GetSolidFireVolumeIscsiName(GetSolidFireVolumeIscsiNameRequest request) => _proxy.Request<ApiSolidFireVolumeIscsiNameResponse>(request);
        public Task<ApiSolidFireVolumeIscsiNameResponse> GetSolidFireVolumeIscsiNameAsync(GetSolidFireVolumeIscsiNameRequest request) => _proxy.RequestAsync<ApiSolidFireVolumeIscsiNameResponse>(request);
    }
}
