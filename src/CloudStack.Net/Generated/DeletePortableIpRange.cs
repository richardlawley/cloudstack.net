using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeletePortableIpRangeRequest : APIRequest
    {
        public DeletePortableIpRangeRequest() : base("deletePortableIpRange") {}

        /// <summary>
        /// Id of the portable ip range
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// deletes a range of portable public IP's associated with a region
    /// </summary>
    /// <summary>
    /// deletes a range of portable public IP's associated with a region
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeletePortableIpRange(DeletePortableIpRangeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeletePortableIpRange(DeletePortableIpRangeRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
