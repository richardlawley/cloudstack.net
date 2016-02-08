using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class GetSPMetadataRequest : APIRequest
    {
        public GetSPMetadataRequest() : base("getSPMetadata") {}

    }
    /// <summary>
    /// Returns SAML2 CloudStack Service Provider MetaData
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SAMLMetaDataResponse GetSPMetadata(GetSPMetadataRequest request);
        Task<SAMLMetaDataResponse> GetSPMetadataAsync(GetSPMetadataRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SAMLMetaDataResponse GetSPMetadata(GetSPMetadataRequest request) => _proxy.Request<SAMLMetaDataResponse>(request);
        public Task<SAMLMetaDataResponse> GetSPMetadataAsync(GetSPMetadataRequest request) => _proxy.RequestAsync<SAMLMetaDataResponse>(request);
    }
}
