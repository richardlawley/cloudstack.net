using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddImageStoreS3Request : APIRequest
    {
        public AddImageStoreS3Request() : base("addImageStoreS3") {}

        /// <summary>
        /// S3 access key
        /// </summary>
        public string AccessKey {
            get { return GetParameterValue<string>(nameof(AccessKey).ToLower()); }
            set { SetParameterValue(nameof(AccessKey).ToLower(), value); }
        }

        /// <summary>
        /// Name of the storage bucket
        /// </summary>
        public string Bucket {
            get { return GetParameterValue<string>(nameof(Bucket).ToLower()); }
            set { SetParameterValue(nameof(Bucket).ToLower(), value); }
        }

        /// <summary>
        /// S3 endpoint
        /// </summary>
        public string EndPoint {
            get { return GetParameterValue<string>(nameof(EndPoint).ToLower()); }
            set { SetParameterValue(nameof(EndPoint).ToLower(), value); }
        }

        /// <summary>
        /// S3 secret key
        /// </summary>
        public string SecretKey {
            get { return GetParameterValue<string>(nameof(SecretKey).ToLower()); }
            set { SetParameterValue(nameof(SecretKey).ToLower(), value); }
        }

        /// <summary>
        /// Connection timeout (milliseconds)
        /// </summary>
        public int? ConnectionTimeout {
            get { return GetParameterValue<int?>(nameof(ConnectionTimeout).ToLower()); }
            set { SetParameterValue(nameof(ConnectionTimeout).ToLower(), value); }
        }

        /// <summary>
        /// Connection TTL (milliseconds)
        /// </summary>
        public int? ConnectionTtl {
            get { return GetParameterValue<int?>(nameof(ConnectionTtl).ToLower()); }
            set { SetParameterValue(nameof(ConnectionTtl).ToLower(), value); }
        }

        /// <summary>
        /// Maximum number of times to retry on error
        /// </summary>
        public int? MaxErrorRetry {
            get { return GetParameterValue<int?>(nameof(MaxErrorRetry).ToLower()); }
            set { SetParameterValue(nameof(MaxErrorRetry).ToLower(), value); }
        }

        /// <summary>
        /// Signer Algorithm to use, either S3SignerType or AWSS3V4SignerType
        /// </summary>
        public string S3signer {
            get { return GetParameterValue<string>(nameof(S3signer).ToLower()); }
            set { SetParameterValue(nameof(S3signer).ToLower(), value); }
        }

        /// <summary>
        /// Socket timeout (milliseconds)
        /// </summary>
        public int? SocketTimeout {
            get { return GetParameterValue<int?>(nameof(SocketTimeout).ToLower()); }
            set { SetParameterValue(nameof(SocketTimeout).ToLower(), value); }
        }

        /// <summary>
        /// Use HTTPS instead of HTTP
        /// </summary>
        public bool? Usehttps {
            get { return GetParameterValue<bool?>(nameof(Usehttps).ToLower()); }
            set { SetParameterValue(nameof(Usehttps).ToLower(), value); }
        }

        /// <summary>
        /// Whether TCP keep-alive is used
        /// </summary>
        public bool? UseTCPKeepAlive {
            get { return GetParameterValue<bool?>(nameof(UseTCPKeepAlive).ToLower()); }
            set { SetParameterValue(nameof(UseTCPKeepAlive).ToLower(), value); }
        }

    }
    /// <summary>
    /// Adds S3 Image Store
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ImageStoreResponse AddImageStoreS3(AddImageStoreS3Request request);
        Task<ImageStoreResponse> AddImageStoreS3Async(AddImageStoreS3Request request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ImageStoreResponse AddImageStoreS3(AddImageStoreS3Request request) => _proxy.Request<ImageStoreResponse>(request);
        public Task<ImageStoreResponse> AddImageStoreS3Async(AddImageStoreS3Request request) => _proxy.RequestAsync<ImageStoreResponse>(request);
    }
}
