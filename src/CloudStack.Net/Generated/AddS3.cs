using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddS3Request : APIRequest
    {
        public AddS3Request() : base("addS3") {}

        /// <summary>
        /// S3 access key
        /// </summary>
        public string AccessKey { get; set; }

        /// <summary>
        /// name of the template storage bucket
        /// </summary>
        public string BucketName { get; set; }

        /// <summary>
        /// S3 secret key
        /// </summary>
        public string SecretKey { get; set; }

        /// <summary>
        /// connection timeout (milliseconds)
        /// </summary>
        public int? ConnectionTimeout { get; set; }

        /// <summary>
        /// connection ttl (milliseconds)
        /// </summary>
        public int? ConnectionTtl { get; set; }

        /// <summary>
        /// S3 host name
        /// </summary>
        public string EndPoint { get; set; }

        /// <summary>
        /// maximum number of times to retry on error
        /// </summary>
        public int? MaxErrorRetry { get; set; }

        /// <summary>
        /// socket timeout (milliseconds)
        /// </summary>
        public int? SocketTimeout { get; set; }

        /// <summary>
        /// connect to the S3 endpoint via HTTPS?
        /// </summary>
        public bool? HttpsFlag { get; set; }

        /// <summary>
        /// whether tcp keepalive is used
        /// </summary>
        public bool? UseTCPKeepAlive { get; set; }

    }
    /// <summary>
    /// Adds S3
    /// </summary>
    /// <summary>
    /// Adds S3
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ImageStoreResponse AddS3(AddS3Request request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ImageStoreResponse AddS3(AddS3Request request) => _proxy.Request<ImageStoreResponse>(request);
    }
}
