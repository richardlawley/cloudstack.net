using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class GetCloudIdentifierRequest : APIRequest
    {
        public GetCloudIdentifierRequest() : base("getCloudIdentifier") {}

        /// <summary>
        /// the user ID for the cloud identifier
        /// </summary>
        public Guid Userid {
            get { return GetParameterValue<Guid>(nameof(Userid).ToLower()); }
            set { SetParameterValue(nameof(Userid).ToLower(), value); }
        }

    }
    /// <summary>
    /// Retrieves a cloud identifier.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        CloudIdentifierResponse GetCloudIdentifier(GetCloudIdentifierRequest request);
        Task<CloudIdentifierResponse> GetCloudIdentifierAsync(GetCloudIdentifierRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public CloudIdentifierResponse GetCloudIdentifier(GetCloudIdentifierRequest request) => _proxy.Request<CloudIdentifierResponse>(request);
        public Task<CloudIdentifierResponse> GetCloudIdentifierAsync(GetCloudIdentifierRequest request) => _proxy.RequestAsync<CloudIdentifierResponse>(request);
    }
}
