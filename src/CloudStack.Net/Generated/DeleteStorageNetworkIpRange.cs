using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteStorageNetworkIpRangeRequest : APIRequest
    {
        public DeleteStorageNetworkIpRangeRequest() : base("deleteStorageNetworkIpRange") {}

        /// <summary>
        /// the uuid of the storage network ip range
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Deletes a storage network IP Range.
    /// </summary>
    /// <summary>
    /// Deletes a storage network IP Range.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteStorageNetworkIpRange(DeleteStorageNetworkIpRangeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteStorageNetworkIpRange(DeleteStorageNetworkIpRangeRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
