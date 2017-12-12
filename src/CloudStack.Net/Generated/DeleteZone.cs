using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteZoneRequest : APIRequest
    {
        public DeleteZoneRequest() : base("deleteZone") {}

        /// <summary>
        /// the ID of the Zone
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a Zone.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteZone(DeleteZoneRequest request);
        Task<SuccessResponse> DeleteZoneAsync(DeleteZoneRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteZone(DeleteZoneRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteZoneAsync(DeleteZoneRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
