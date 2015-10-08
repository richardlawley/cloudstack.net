using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class GetSolidFireAccountIdRequest : APIRequest
    {
        public GetSolidFireAccountIdRequest() : base("getSolidFireAccountId") {}

        /// <summary>
        /// CloudStack Account UUID
        /// </summary>
        public string AccountUuid { get; set; }

        /// <summary>
        /// Storage Pool UUID
        /// </summary>
        public string StoragePoolUuid { get; set; }

    }
    /// <summary>
    /// Get SolidFire Account ID
    /// </summary>
    /// <summary>
    /// Get SolidFire Account ID
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ApiSolidFireAccountIdResponse GetSolidFireAccountId(GetSolidFireAccountIdRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ApiSolidFireAccountIdResponse GetSolidFireAccountId(GetSolidFireAccountIdRequest request) => _proxy.Request<ApiSolidFireAccountIdResponse>(request);
    }
}
