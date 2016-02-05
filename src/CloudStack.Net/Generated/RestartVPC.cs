using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RestartVPCRequest : APIRequest
    {
        public RestartVPCRequest() : base("restartVPC") {}

        /// <summary>
        /// the id of the VPC
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// If cleanup old network elements
        /// </summary>
        public bool? Cleanup {
            get { return (bool?) Parameters[nameof(Cleanup).ToLower()]; }
            set { Parameters[nameof(Cleanup).ToLower()] = value; }
        }

        /// <summary>
        /// Turn a single VPC into a redundant one.
        /// </summary>
        public bool? Makeredundant {
            get { return (bool?) Parameters[nameof(Makeredundant).ToLower()]; }
            set { Parameters[nameof(Makeredundant).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Restarts a VPC
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse RestartVPC(RestartVPCRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse RestartVPC(RestartVPCRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
