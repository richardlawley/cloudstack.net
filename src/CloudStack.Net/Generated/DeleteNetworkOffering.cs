using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteNetworkOfferingRequest : APIRequest
    {
        public DeleteNetworkOfferingRequest() : base("deleteNetworkOffering") {}

        /// <summary>
        /// the ID of the network offering
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a network offering.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteNetworkOffering(DeleteNetworkOfferingRequest request);
        Task<SuccessResponse> DeleteNetworkOfferingAsync(DeleteNetworkOfferingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteNetworkOffering(DeleteNetworkOfferingRequest request) => _proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteNetworkOfferingAsync(DeleteNetworkOfferingRequest request) => _proxy.RequestAsync<SuccessResponse>(request);
    }
}
