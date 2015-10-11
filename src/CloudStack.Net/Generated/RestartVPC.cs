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

    }
    /// <summary>
    /// Restarts a VPC
    /// </summary>
    /// <summary>
    /// Restarts a VPC
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        VpcResponse RestartVPC(RestartVPCRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public VpcResponse RestartVPC(RestartVPCRequest request) => _proxy.Request<VpcResponse>(request);
    }
}
