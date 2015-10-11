using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteVPCRequest : APIRequest
    {
        public DeleteVPCRequest() : base("deleteVPC") {}

        /// <summary>
        /// the ID of the VPC
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Deletes a VPC
    /// </summary>
    /// <summary>
    /// Deletes a VPC
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteVPC(DeleteVPCRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteVPC(DeleteVPCRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
