using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class GetSolidFireAccountIdRequest : APIRequest
    {
        public GetSolidFireAccountIdRequest() : base("getSolidFireAccountId") {}

        /// <summary>
        /// CloudStack Account UUID
        /// </summary>
        public string Accountid {
            get { return GetParameterValue<string>(nameof(Accountid).ToLower()); }
            set { SetParameterValue(nameof(Accountid).ToLower(), value); }
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
    /// Get SolidFire Account ID
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ApiSolidFireAccountIdResponse GetSolidFireAccountId(GetSolidFireAccountIdRequest request);
        Task<ApiSolidFireAccountIdResponse> GetSolidFireAccountIdAsync(GetSolidFireAccountIdRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ApiSolidFireAccountIdResponse GetSolidFireAccountId(GetSolidFireAccountIdRequest request) => _proxy.Request<ApiSolidFireAccountIdResponse>(request);
        public Task<ApiSolidFireAccountIdResponse> GetSolidFireAccountIdAsync(GetSolidFireAccountIdRequest request) => _proxy.RequestAsync<ApiSolidFireAccountIdResponse>(request);
    }
}
