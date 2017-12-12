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
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
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
        public SuccessResponse DeleteDiskOffering(DeleteDiskOfferingRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteDiskOfferingAsync(DeleteDiskOfferingRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
