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
        public string Accountid {
            get { return (string) Parameters[nameof(Accountid).ToLower()]; }
            set { Parameters[nameof(Accountid).ToLower()] = value; }
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
