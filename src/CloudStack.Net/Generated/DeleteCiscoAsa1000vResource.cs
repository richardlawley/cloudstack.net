using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteCiscoAsa1000vResourceRequest : APIRequest
    {
        public DeleteCiscoAsa1000vResourceRequest() : base("deleteCiscoAsa1000vResource") {}

        /// <summary>
        /// Cisco ASA 1000v resource ID
        /// </summary>
        public Guid Resourceid {
            get { return GetParameterValue<Guid>(nameof(Resourceid).ToLower()); }
            set { SetParameterValue(nameof(Resourceid).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a Cisco ASA 1000v appliance
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteCiscoAsa1000vResource(DeleteCiscoAsa1000vResourceRequest request);
        Task<SuccessResponse> DeleteCiscoAsa1000vResourceAsync(DeleteCiscoAsa1000vResourceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteCiscoAsa1000vResource(DeleteCiscoAsa1000vResourceRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteCiscoAsa1000vResourceAsync(DeleteCiscoAsa1000vResourceRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
