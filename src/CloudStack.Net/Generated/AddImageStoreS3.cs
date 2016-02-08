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
            get { return (string) Parameters[nameof(AccessKey).ToLower()]; }
            set { Parameters[nameof(AccessKey).ToLower()] = value; }
        }

        /// <summary>
        /// Name of the storage bucket
        /// </summary>
        public string Bucket {
            get { return (string) Parameters[nameof(Bucket).ToLower()]; }
            set { Parameters[nameof(Bucket).ToLower()] = value; }
        }

        /// <summary>
        /// S3 endpoint
        /// </summary>
        public string EndPoint {
            get { return (string) Parameters[nameof(EndPoint).ToLower()]; }
            set { Parameters[nameof(EndPoint).ToLower()] = value; }
        }

        /// <summary>
        /// S3 secret key
        /// </summary>
        public string SecretKey {
            get { return (string) Parameters[nameof(SecretKey).ToLower()]; }
            set { Parameters[nameof(SecretKey).ToLower()] = value; }
        }

        /// <summary>
        /// Connection timeout (milliseconds)
        /// </summary>
        public int? ConnectionTimeout {
            get { return (int?) Parameters[nameof(ConnectionTimeout).ToLower()]; }
            set { Parameters[nameof(ConnectionTimeout).ToLower()] = value; }
        }

        /// <summary>
        /// Connection TTL (milliseconds)
        /// </summary>
        public int? ConnectionTtl {
            get { return (int?) Parameters[nameof(ConnectionTtl).ToLower()]; }
            set { Parameters[nameof(ConnectionTtl).ToLower()] = value; }
        }

        /// <summary>
        /// Maximum number of times to retry on error
        /// </summary>
        public int? MaxErrorRetry {
            get { return (int?) Parameters[nameof(MaxErrorRetry).ToLower()]; }
            set { Parameters[nameof(MaxErrorRetry).ToLower()] = value; }
        }

        /// <summary>
        /// Signer Algorithm to use, either S3SignerType or AWSS3V4SignerType
        /// </summary>
        public string S3signer {
            get { return (string) Parameters[nameof(S3signer).ToLower()]; }
            set { Parameters[nameof(S3signer).ToLower()] = value; }
        }

        /// <summary>
        /// Socket timeout (milliseconds)
        /// </summary>
        public int? SocketTimeout {
            get { return (int?) Parameters[nameof(SocketTimeout).ToLower()]; }
            set { Parameters[nameof(SocketTimeout).ToLower()] = value; }
        }

        /// <summary>
        /// Use HTTPS instead of HTTP
        /// </summary>
        public bool? Usehttps {
            get { return (bool?) Parameters[nameof(Usehttps).ToLower()]; }
            set { Parameters[nameof(Usehttps).ToLower()] = value; }
        }

        /// <summary>
        /// Whether TCP keep-alive is used
        /// </summary>
        public bool? UseTCPKeepAlive {
            get { return (bool?) Parameters[nameof(UseTCPKeepAlive).ToLower()]; }
            set { Parameters[nameof(UseTCPKeepAlive).ToLower()] = value; }
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
