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
        public string AccessKey {
            get { return (string) Parameters[nameof(AccessKey).ToLower()]; }
            set { Parameters[nameof(AccessKey).ToLower()] = value; }
        }

        /// <summary>
        /// name of the template storage bucket
        /// </summary>
        public string Bucket {
            get { return (string) Parameters[nameof(Bucket).ToLower()]; }
            set { Parameters[nameof(Bucket).ToLower()] = value; }
        }

        /// <summary>
        /// S3 secret key
        /// </summary>
        public string SecretKey {
            get { return (string) Parameters[nameof(SecretKey).ToLower()]; }
            set { Parameters[nameof(SecretKey).ToLower()] = value; }
        }

        /// <summary>
        /// connection timeout (milliseconds)
        /// </summary>
        public int? ConnectionTimeout {
            get { return (int?) Parameters[nameof(ConnectionTimeout).ToLower()]; }
            set { Parameters[nameof(ConnectionTimeout).ToLower()] = value; }
        }

        /// <summary>
        /// S3 host name
        /// </summary>
        public string EndPoint {
            get { return (string) Parameters[nameof(EndPoint).ToLower()]; }
            set { Parameters[nameof(EndPoint).ToLower()] = value; }
        }

        /// <summary>
        /// maximum number of times to retry on error
        /// </summary>
        public int? MaxErrorRetry {
            get { return (int?) Parameters[nameof(MaxErrorRetry).ToLower()]; }
            set { Parameters[nameof(MaxErrorRetry).ToLower()] = value; }
        }

        /// <summary>
        /// socket timeout (milliseconds)
        /// </summary>
        public int? SocketTimeout {
            get { return (int?) Parameters[nameof(SocketTimeout).ToLower()]; }
            set { Parameters[nameof(SocketTimeout).ToLower()] = value; }
        }

        /// <summary>
        /// connect to the S3 endpoint via HTTPS?
        /// </summary>
        public bool? Usehttps {
            get { return (bool?) Parameters[nameof(Usehttps).ToLower()]; }
            set { Parameters[nameof(Usehttps).ToLower()] = value; }
        }

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
