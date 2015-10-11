using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteVPCOfferingRequest : APIRequest
    {
        public DeleteVPCOfferingRequest() : base("deleteVPCOffering") {}

        /// <summary>
        /// the ID of the VPC offering
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Deletes VPC offering
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteVPCOffering(DeleteVPCOfferingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteVPCOffering(DeleteVPCOfferingRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
