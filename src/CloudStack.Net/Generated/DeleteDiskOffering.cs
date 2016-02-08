using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteDiskOfferingRequest : APIRequest
    {
        public DeleteDiskOfferingRequest() : base("deleteDiskOffering") {}

        /// <summary>
        /// ID of the disk offering
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Updates a disk offering.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteDiskOffering(DeleteDiskOfferingRequest request);
        Task<SuccessResponse> DeleteDiskOfferingAsync(DeleteDiskOfferingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteDiskOffering(DeleteDiskOfferingRequest request) => _proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteDiskOfferingAsync(DeleteDiskOfferingRequest request) => _proxy.RequestAsync<SuccessResponse>(request);
    }
}
