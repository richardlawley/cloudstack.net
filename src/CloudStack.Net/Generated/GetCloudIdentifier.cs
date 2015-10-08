using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class GetCloudIdentifierRequest : APIRequest
    {
        public GetCloudIdentifierRequest() : base("getCloudIdentifier") {}

        /// <summary>
        /// the user ID for the cloud identifier
        /// </summary>
        public Guid Userid { get; set; }

    }
    /// <summary>
    /// Retrieves a cloud identifier.
    /// </summary>
    /// <summary>
    /// Retrieves a cloud identifier.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        CloudIdentifierResponse GetCloudIdentifier(GetCloudIdentifierRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public CloudIdentifierResponse GetCloudIdentifier(GetCloudIdentifierRequest request) => _proxy.Request<CloudIdentifierResponse>(request);
    }
}
