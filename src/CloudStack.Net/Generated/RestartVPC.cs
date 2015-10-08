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
        public Guid Id { get; set; }

        /// <summary>
        /// If cleanup old network elements
        /// </summary>
        public bool? Cleanup { get; set; }

        /// <summary>
        /// Turn a single VPC into a redundant one.
        /// </summary>
        public bool? Makeredundant { get; set; }

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
