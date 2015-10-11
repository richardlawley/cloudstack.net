using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ReleasePublicIpRangeRequest : APIRequest
    {
        public ReleasePublicIpRangeRequest() : base("releasePublicIpRange") {}

        /// <summary>
        /// the id of the Public IP range
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Releases a Public IP range back to the system pool
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse ReleasePublicIpRange(ReleasePublicIpRangeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse ReleasePublicIpRange(ReleasePublicIpRangeRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
